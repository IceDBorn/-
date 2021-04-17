using System;
using System.Collections.Generic;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers.Classic;
using Lucene.Net.Search;
using Lucene.Net.Store;
using Lucene.Net.Util;

namespace filmhub.Controllers
{
    public class SearchEngine
    {
        private String path;    
        
        public SearchEngine(String path)
        {
            //path is the folder for index files
            this.path = path;
        }
        
        public IndexWriter CreateWriter()
        {
            FSDirectory dir = FSDirectory.Open(path);
            IndexWriterConfig config = new IndexWriterConfig(LuceneVersion.LUCENE_48,new StandardAnalyzer(LuceneVersion.LUCENE_48));
            IndexWriter writer = new IndexWriter(dir, config);
            return writer;
        }
        
        
        //Create entity for indexing. ID=movie id in database, text=text to be scanned on user search (title+" "+stars"+" "+...)
        public Document CreateDocument(int id, String movie, String text) 
        {
            Document document = new Document();
            document.Add(new StringField("id", id.ToString() , Field.Store.YES));
            document.Add(new TextField("text", text , Field.Store.YES));
            return document;
        }
        
        public IndexSearcher CreateSearcher()
        {
            Directory dir = FSDirectory.Open(path);
            IndexReader reader = DirectoryReader.Open(dir);
            IndexSearcher searcher = new IndexSearcher(reader);
            return searcher;
        }
        
        public TopDocs Search(String text, IndexSearcher searcher)
        {
            QueryParser qp = new QueryParser(LuceneVersion.LUCENE_40, "text",
                new StandardAnalyzer(LuceneVersion.LUCENE_40));
            Query idQuery = qp.Parse(text);
            TopDocs hits = searcher.Search(idQuery,10);
            return hits;
        }
        
        public void Indexer(List<Document> list)
        {
            IndexWriter writer = CreateWriter();
            writer.AddDocuments(list);
            writer.Commit();
            writer.Dispose();
        }

        public List<int> SearchIdResults(String searchQuery)
        {
            IndexSearcher searcher = CreateSearcher();
            TopDocs foundDocs = Search(searchQuery, searcher);
            
            //FOR TESTING:
            Console.WriteLine("Total Results :: " + foundDocs.TotalHits);

            List<int> results = new List<int>();
            foreach (ScoreDoc sd in foundDocs.ScoreDocs)
            {
                results.Add(Int32.Parse(searcher.Doc(sd.Doc).Get("id")));
            }
            return results;
        }
        
        
        /*
        EXAMPLE INDEXING
        Document d1 = CreateDocument(1,"Shrek Animation Commedy Actorname1 Actorname2 ...");
        List<Document> list= new List<Document>();
        list.Add(d1);
        Indexer(list);
        */
        
        /*
        EXAMPLE SEARCH
        searchQuery= "Comedy 2019 2020";
        List<int> list = SearchIdResults(searchQuery);
        foreach(int i in list){
            //pull content from database with id number i
        }
         
        */
        
    }
}