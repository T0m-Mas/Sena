using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sena;

namespace Sena_2
{
    class CEjecutora
    {    
        static List<Sena> listaSenas = new List<Sena>(32);
        static List<User> listaUsers = new List<User>(5);
        static public User currUser;

        static string rutausers = "userbase.sen";
        static string rutauserstemp = Path.GetTempFileName();
        static string rutalista = Path.GetTempFileName();
        static string rutamainkey = "entry";

        static Stream temp = new FileStream(rutalista, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
        static Stream tempUs = new FileStream(rutauserstemp, FileMode.Create, FileAccess.ReadWrite, FileShare.None);

        [STAThread]
        static void Main()
        {
            
            Leer("users");

            var inicio = new frmGestion();
            inicio.ShowDialog();
            if (inicio.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();//Si se cancela el inicio de sesion
            }
            else
            {
                inicio.Dispose();
                Leer("senas");
                temp.Close();
                if (File.Exists(rutalista)) { File.Delete(rutalista); }//borro temporal por las dudas, total ya esta cargado en memoria                
                Application.EnableVisualStyles();
                Application.Run(new frmMain());
            }
        }
        static int f = 0;
        public static string DarNombre(int opc)
        {
            int N = listaSenas.Count();
            f = 0;
            if (f < N)
            {
                f++;
                return listaSenas[f-1].Nom;
            }
            else
            {
                return "\n";
            }

        }
        public static string DarNombre()
        {
            int N = listaSenas.Count();
            
            if (f < N)
            {
                f++;
                return listaSenas[f-1].Nom;
            }
            else
            {
                return "\n";
            }

        }

        private static void Grabar()
        {
            try
            {
                BinaryFormatter formateador = new BinaryFormatter();
                Stream fs = new FileStream(currUser.GetRuta(), FileMode.Create, FileAccess.Write, FileShare.None);

                formateador.Serialize(fs, listaSenas);
                fs.Close();

                Cifrar(currUser.GetRuta());                

            }
            catch(DirectoryNotFoundException)
            {
                Directory.CreateDirectory("data\\");
                try
                {
                    BinaryFormatter formateador = new BinaryFormatter();
                    Stream fs = new FileStream(currUser.GetRuta(), FileMode.Create, FileAccess.Write, FileShare.None);

                    formateador.Serialize(fs, listaSenas);

                    fs.Close();

                    Cifrar(currUser.GetRuta());
                }
                catch
                {
                    MessageBox.Show("Se produjo un error al guardar");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                Application.Exit();
            }


        }

        private static void DeCifrar()
        {
            /* METODO OMITIDO */
        }
        private static void Cifrar(string ruta)
        {
            /* METODO OMITIDO */
        }

        private static void UCifrar(){

            /* METODO OMITIDO */
        }

        private static void UDescifrar()
        {
            /* METODO OMITIDO */
        }

        private static void GrabarUsers()
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream fs = new FileStream(CEjecutora.rutausers, FileMode.Create, FileAccess.Write, FileShare.None);
            formateador.Serialize(fs, listaUsers);
            fs.Close();

            //encripto  
            UCifrar();


        }
        private static void Leer(string opc)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            if (opc == "senas")
            {
                try
                {                 
                    
                    Stream senaStream = new FileStream(currUser.GetRuta(), FileMode.Open, FileAccess.Read, FileShare.None);
                    byte[] contenido = new byte[senaStream.Length];

                    for(int f = 0; f < contenido.Length; f++)
                    {
                        contenido[f] = (byte)senaStream.ReadByte();
                        temp.WriteByte(contenido[f]);
                    }
                    senaStream.Close();
                    DeCifrar();
                    listaSenas = (List<Sena>) formateador.Deserialize(temp);
                    
                }
                catch (FileNotFoundException)
                {
                    Grabar();
                }
                catch(DirectoryNotFoundException)
                {
                    //MessageBox.Show("");
                    Directory.CreateDirectory("data\\");
                }
                catch(System.Runtime.Serialization.SerializationException)
                {
                    File.Delete(currUser.GetRuta());
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            if (opc == "users")
            {
                if (File.Exists(rutausers))
                {
                    UDescifrar();
                    try
                    {
                        listaUsers = (List<User>)formateador.Deserialize(tempUs);
                    }
                    catch
                    {
                        MessageBox.Show("Se produjo un error");
                        return;
                    }

                    tempUs.Close();
                }
                else
                {
                    File.Delete(rutamainkey);
                }
            }

        }

        public static Sena DarDatos(int index)
        {
            if (index >= 0) { return listaSenas[index]; }
            else { return null; } ;

        }
        public static void Agregar(string nomin,string passin, string userin,string mailin,string plusin )
        {
            Sena nuevo = new Sena();

            nuevo.Nom = nomin;
            nuevo.User = userin;
            nuevo.Pass = passin;
            nuevo.Mail = mailin;
            nuevo.Extra = plusin;

            listaSenas.Add(nuevo);

            Grabar();

        }
        public static void Editar(int N,string nomin,string passin, string userin,string mailin,string plusin )
        {
            
            if (N > listaSenas.Count || N < 0) { return; }

            listaSenas[N].Nom = nomin;
            listaSenas[N].Pass = passin;
            listaSenas[N].User = userin;
            listaSenas[N].Mail = mailin;
            listaSenas[N].Extra = plusin;

            Grabar();

        }
        public static void Eliminar(int N)
        {
            if (N <= listaSenas.Count())
            { 
                listaSenas.RemoveAt(N);
            }
            Grabar();
            
        }
        
        //Gestion
        public static bool ULogin(string usin, string passin)
        {
            if (UExtraer(usin)!=null)
            {
                User uslog = UExtraer(usin);
                if (uslog.Verificar(passin))
                {
                    currUser = uslog;
                    return true;
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta", "Error Login", MessageBoxButtons.OK);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado el usuario ingresado", "Error Login", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool URegister(string usin,string passin)
        {
            if (!UBuscar(usin))
            {
                User usnew = new User(usin, passin);
                string nuevaruta = "data\\";

                //Creacion de ruta de archivo

                nuevaruta += "userdata" + listaUsers.Count + 1.ToString() + ".sen";
                usnew.SetRuta(nuevaruta);

                //Guardo
                listaUsers.Add(usnew);
                GrabarUsers();
                currUser = usnew;
                return true;
            }
            else
            {
                MessageBox.Show("Ya existe un usuario registrado con ese nombre", "Error Registro", MessageBoxButtons.OK);
                return false;
            }
        }

        public static void UEdit(string opc,string str)
        {
            if (opc == "user")
            {
                CEjecutora.currUser.SetNom(str);
            }
            if (opc == "pass")
            {
                CEjecutora.currUser.SetPass(str);
            }

            for (int f = 0; f < listaUsers.Count(); f++)
            {
                if (listaUsers[f].GetKey() == CEjecutora.currUser.GetKey())
                {
                    listaUsers.RemoveAt(f);
                    listaUsers.Insert(f, currUser);
                }
            }
            GrabarUsers();
        }

        private static User UExtraer(string nomin)
        {
            for (ushort f = 0; f < listaUsers.Count; f++)
            {
                if (listaUsers[f].GetNom() == nomin)
                {
                    return listaUsers[f];
                }
            }
            return null;
        }
        public static bool UBuscar(string nomin)
        {
            for(ushort f = 0; f < listaUsers.Count; f++)
            {
                if (listaUsers[f].GetNom() == nomin)
                {
                    return true;
                }
            }
            return false;
        }
        public static void URemove(User usdel)
        {
            for (ushort f = 0; f < listaUsers.Count; f++)
            {
                if (listaUsers[f] == usdel)
                {
                    listaUsers.RemoveAt(f);
                }
            }
            File.Delete(currUser.GetRuta());
            GrabarUsers();
            Application.Restart();
        }
        public static ushort NumUsers()
        {
            return (ushort) listaUsers.Count();
        }

        public static int GetNumSenas()
        {
            return CEjecutora.listaSenas.Count();
        }



    }     

   
}
