using System;
using System.Collections.Generic;
using System.Windows.Forms;
using filmhub.Models;
using Npgsql;

namespace filmhub.Controllers
{
    public static class MovieController
    {
        private static readonly NpgsqlConnection con = DatabaseController.GetConnection();

        public enum Section
        {
            Featured,
            ComingSoon
        }

        public static List<Movie> MainPageMovieQuery(Section section)
        {
            var movies = new List<Movie>();
            var query = "SELECT id, picture FROM movie WHERE release_date ";
            
            if (section == Section.Featured)
            {
                query += "<";
            }
            else
            {
                query += ">";
            }
            
            query += " NOW() ORDER BY RANDOM() LIMIT 5";

            try
            {
                using var cmd = new NpgsqlCommand(query, con);
                using var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var movie = new Movie {Id = rdr.GetInt32(0), Picture = rdr.GetString(1)};
                    movies.Add(movie);
                }

                rdr.Close();
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show(e.Message);
            }
            catch
            {
                MessageBox.Show(@"Something went wrong while contacting the database.");
            }

            return movies;
        }
    }
}