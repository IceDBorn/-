using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers.Classic;
using Lucene.Net.Search;
using Lucene.Net.Store;
using Lucene.Net.Util;
using Npgsql;

namespace filmhub.Controllers
{
    public class SearchController
    {
        private static string _path;

        public SearchController(string path)
        {
            // Path is the folder for index files
            _path = path;
        }

        private static IndexWriter CreateWriter()
        {
            var dir = FSDirectory.Open(_path);
            var config = new IndexWriterConfig(LuceneVersion.LUCENE_48, new StandardAnalyzer(LuceneVersion.LUCENE_48));
            var writer = new IndexWriter(dir, config);
            return writer;
        }

        private static Document CreateDocument(int id, string text)
        {
            var document = new Document
            {
                new StringField("id", id.ToString(), Field.Store.YES),
                new TextField("text", text, Field.Store.YES)
            };
            return document;
        }

        private static IndexSearcher CreateSearcher()
        {
            Directory dir = FSDirectory.Open(_path);
            IndexReader reader = DirectoryReader.Open(dir);
            var searcher = new IndexSearcher(reader);
            return searcher;
        }

        private static TopDocs Search(string text, IndexSearcher searcher)
        {
            var qp = new QueryParser(LuceneVersion.LUCENE_40, "text",
                new StandardAnalyzer(LuceneVersion.LUCENE_40));
            var escapedString = QueryParserBase.Escape(text);
            var idQuery = qp.Parse(escapedString);
            var hits = searcher.Search(idQuery, 10);
            return hits;
        }

        private static void Indexer(IEnumerable<Document> list)
        {
            var writer = CreateWriter();
            writer.AddDocuments(list);
            writer.Commit();
            writer.Dispose();
        }

        public static IEnumerable<int> SearchIdResults(string searchQuery)
        {
            var searcher = CreateSearcher();
            var foundDocs = Search(searchQuery, searcher);

            //FOR TESTING:
            Console.WriteLine("Total Results :: " + foundDocs.TotalHits);

            var results = new List<int>();
            foreach (var sd in foundDocs.ScoreDocs)
            {
                results.Add(int.Parse(searcher.Doc(sd.Doc).Get("id")));
            }

            return results;
        }

        public static void createIndex()
        {
            try
            {
                var con = DatabaseController.getConnection();
                con.Open();

                const string movieData = "SELECT id,name " +
                                         "FROM movie ";

                using var cmd = new NpgsqlCommand(movieData, con);

                using var rdr = cmd.ExecuteReader();

                var list = new List<Document>();

                while (rdr.Read())
                {
                    list.Add(CreateDocument(rdr.GetInt32(0), rdr.GetString(1)));
                }

                Indexer(list);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}