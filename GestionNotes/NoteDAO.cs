using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestionNotes
{
   
        public class NoteDAO
        {
            public static List<Note> GetNotesParEtudiant(int etudiantId)
            {
                var list = new List<Note>();
                using (SqlConnection con = Connexion.GetConnection())
                {
                    con.Open();
                    string query = @"SELECT n.Id, n.Note, m.Nom as NomMatiere, m.Id as MatiereId 
                                 FROM Notes n 
                                 JOIN Matieres m ON m.Id = n.MatiereId 
                                 WHERE n.EtudiantId = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", etudiantId);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        list.Add(new Note
                        {
                            Id = (int)dr["Id"],
                            Valeur = (double)dr["Note"],
                            MatiereId = (int)dr["MatiereId"],
                            NomMatiere = dr["NomMatiere"].ToString()
                        });
                    }
                }
                return list;
            }

            public static void Ajouter(Note n)
            {
                using (SqlConnection con = Connexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Notes (EtudiantId, MatiereId, Note) VALUES (@E, @M, @N)", con);
                    cmd.Parameters.AddWithValue("@E", n.EtudiantId);
                    cmd.Parameters.AddWithValue("@M", n.MatiereId);
                    cmd.Parameters.AddWithValue("@N", n.Valeur);
                    cmd.ExecuteNonQuery();
                }
            }

            public static void Supprimer(int noteId)
            {
                using (SqlConnection con = Connexion.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Notes WHERE Id = @Id", con);
                    cmd.Parameters.AddWithValue("@Id", noteId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

