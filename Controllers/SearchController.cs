using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using filmhub.Controls;
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
    public static class SearchController
    {
        private const string _path = "./IndexedSearch";

        private static void Indexer(IEnumerable<Document> list)
        {
            var writer = CreateWriter();
            writer.AddDocuments(list);
            writer.Commit();
            writer.Dispose();
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
            var qp = new QueryParser(LuceneVersion.LUCENE_48, "text",
                new StandardAnalyzer(LuceneVersion.LUCENE_48));
            var escapedString = QueryParserBase.Escape(text);
            var idQuery = qp.Parse(escapedString);
            var hits = searcher.Search(idQuery, 10);
            return hits;
        }

        public static IEnumerable<int> CreateIndexFolder(string result)
        {
            if (!System.IO.Directory.Exists(_path) || IsDirectoryEmpty(_path))
                CreateIndex();
            var list = new List<int>(SearchIdResults(result));
            return list;
        }

        private static IEnumerable<int> SearchIdResults(string searchQuery)
        {
            var searcher = CreateSearcher();
            var foundDocs = Search(searchQuery, searcher);

            var results = new List<int>();
            foreach (var sd in foundDocs.ScoreDocs)
            {
                results.Add(int.Parse(searcher.Doc(sd.Doc).Get("id")));
            }

            return results;
        }

        public static void CreateIndex()
        {
            try
            {
                var con = DatabaseController.GetConnection();

                const string movieData = "SELECT id,name " +
                                         "FROM movie ";

                using var cmd = new NpgsqlCommand(movieData, con);

                using var rdr = cmd.ExecuteReader();

                var list = new List<Document>();

                while (rdr.Read())
                {
                    list.Add(CreateDocument(rdr.GetInt32(0), rdr.GetString(1)));
                }

                rdr.Close();

                Indexer(list);
            }
            catch (Exception e)
            {
                CustomMessageBox.Show(e.Message);
            }
        }
        
        public static async Task CreateIndexAsync()
        {
            try
            {
                var con = DatabaseController.GetConnection();

                const string movieData = "SELECT id,name " +
                                         "FROM movie ";

                using var cmd = new NpgsqlCommand(movieData, con);

                await using var rdr = await cmd.ExecuteReaderAsync();

                var list = new List<Document>();

                while (rdr.Read())
                {
                    list.Add(CreateDocument(rdr.GetInt32(0), rdr.GetString(1)));
                }

                await rdr.CloseAsync();

                Indexer(list);
            }
            catch (Exception e)
            {
                CustomMessageBox.Show(e.Message);
            }
        }

        public static void RemoveIndex()
        {
            try
            {
                if (System.IO.Directory.Exists(_path))
                {
                    System.IO.Directory.Delete(_path, true);
                }
            }
            catch (Exception e)
            {
                CustomMessageBox.Show(e.Message);
            }
        }

        private static bool IsDirectoryEmpty(string path)
        {
            return !System.IO.Directory.EnumerateFileSystemEntries(path).Any();
        }
    }
}