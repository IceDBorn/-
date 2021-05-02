using System;
using System.Collections.Generic;
using System.Windows.Forms;
using filmhub.Models;
using Npgsql;
using NpgsqlTypes;

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

        public static Movie MovieViewerQuery(int id)
        {
            var movie = new Movie();
            var query =
                "SELECT movie.name, description, director, writer, stars, release_date, genre.name " +
                "FROM movie " +
                "JOIN genre ON genre_id = genre.id " +
                "WHERE movie.id = @id";

            var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                try
                {
                    movie.Name = rdr.GetString(0);
                    movie.Description = rdr.GetString(1);
                    movie.Director = rdr.GetString(2);
                    movie.Writer = rdr.GetString(3);
                    movie.Stars = rdr.GetString(4);
                    movie.ReleaseDate = rdr.GetDate(5).ToString();
                    movie.Genre = rdr.GetString(6);
                }
                catch
                {
                    MessageBox.Show(@"Something went wrong while contacting the database.");
                }
            }

            rdr.Close();

            query = "SELECT value FROM rating WHERE movie_id = @id AND user_id = @user_id";

            cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("user_id", Account.GetAccountInstance().Id);
            cmd.Prepare();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                try
                {
                    movie.Rating = rdr.GetInt32(0);
                }
                catch
                {
                    MessageBox.Show(@"Something went wrong while contacting the database.");
                }
            }

            rdr.Close();

            return movie;
        }

        public static void UpdateMovie(int id, string title, string directors, string writers, string stars,
            string date, string description)
        {
            const string query =
                "UPDATE movie " +
                "SET (name, description, director, writer, stars, release_date) " +
                "= (@title, @description, @directors, @writers, @stars, @release_date) " +
                "WHERE id = @id";

            try
            {
                using var cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("title", title);
                cmd.Parameters.AddWithValue("description", description);
                cmd.Parameters.AddWithValue("directors", directors);
                cmd.Parameters.AddWithValue("writers", writers);
                cmd.Parameters.AddWithValue("stars", stars);
                cmd.Parameters.AddWithValue("release_date", NpgsqlDate.Parse(date));
                cmd.Parameters.AddWithValue("id", id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        
    }
}