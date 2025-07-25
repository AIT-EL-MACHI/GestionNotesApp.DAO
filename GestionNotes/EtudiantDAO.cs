using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionNotesApp.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestionNotes
{

   
        public class EtudiantDAO
        {
            public static List<Etudiant> GetAll()
            {
                var list = new List<Etudiant>();
                using (SqlConnection con = Connexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Etudiants", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        list.Add(new Etudiant
                        {
                            Id = (int)dr["Id"],
                            Nom = dr["Nom"].ToString(),
                            Prenom = dr["Prenom"].ToString()
                        });
                    }
                }
                return list;
            }

            public static void Ajouter(Etudiant e)
            {
                using (SqlConnection con = Connexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Etudiants (Nom, Prenom) VALUES (@Nom, @Prenom)", con);
                    cmd.Parameters.AddWithValue("@Nom", e.Nom);
                    cmd.Parameters.AddWithValue("@Prenom", e.Prenom);
                    cmd.ExecuteNonQuery();
                }
            }

            public static void Modifier(Etudiant e)
            {
                using (SqlConnection con = Connexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Etudiants SET Nom=@Nom, Prenom=@Prenom WHERE Id=@Id", con);
                    cmd.Parameters.AddWithValue("@Id", e.Id);
                    cmd.Parameters.AddWithValue("@Nom", e.Nom);
                    cmd.Parameters.AddWithValue("@Prenom", e.Prenom);
                    cmd.ExecuteNonQuery();
                }
            }

            public static void Supprimer(int id)
            {
                using (SqlConnection con = Connexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Etudiants WHERE Id=@Id", con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }


