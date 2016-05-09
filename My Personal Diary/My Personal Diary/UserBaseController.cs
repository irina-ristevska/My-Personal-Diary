using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace My_Personal_Diary
{
    class UserBaseController
    {
        static readonly string XMLurl = "MyPersonalDiary.xml"; // ***treba da se smeni vo relativna pateka***
        DataSet XMLset = new DataSet();
        DataRow []XMLresult; 
        int userIndex = -1;

        public void LoadXML()
        {
            if(!File.Exists(XMLurl)) //Kreiranje na nova prazna tabela ako ne postoi xml bazata
            {
                DataTable table = new DataTable();
                table.Columns.Add(new DataColumn("UserName", Type.GetType("System.String")));
                table.Columns.Add(new DataColumn("Password", Type.GetType("System.String")));
                table.Columns.Add(new DataColumn("DiaryFile", Type.GetType("System.String")));

                XMLset.Tables.Add(table);
                XMLset.Tables[0].TableName = "Users";

                UpdateXMLfile(); 
            }

            GetXMLfile();
        }

        public bool SignUpUser(string username, string password)
        {
            XMLresult = XMLset.Tables[0].Select("UserName = '" + username + "' AND Password = '" + password + "'");

            int a = XMLresult.Length;
            if (XMLresult.Length>0) // Ako userot veke postoi, ne treba da mozhe da se kreira duplikat user
            {
                userIndex = -1;
                return false;
            }

            else
            {
                DataRow newUser = XMLset.Tables[0].NewRow(); //kreiranje na nov user i dodavanje vo xml fajlot
                newUser["UserName"] = username;
                newUser["Password"] = password;
                newUser["DiaryFile"] = username + ".mpd";
                XMLset.Tables[0].Rows.Add(newUser);
                UpdateXMLfile();
                userIndex = XMLset.Tables[0].Rows.IndexOf(newUser);

                return true;
            }


        }

        public bool LogInUser(string username, string password)
        {
            XMLresult = XMLset.Tables[0].Select("UserName = '" + username + "' AND Password = '" + password + "'");
            if(XMLresult.Length>0)
            {
                userIndex = XMLset.Tables[0].Rows.IndexOf(XMLresult[0]);
                return true;
            }
            else
            {
                userIndex = -1;
                return false;

            }

        }

        public string GetDiaryFile() // .mpd fajlot od xml bazata
        {
            if (userIndex > -1)
                return XMLset.Tables[0].Rows[userIndex]["DiaryFile"].ToString();
            else
                return "";
        }

        private void UpdateXMLfile() //zapishi go XMLset vo xml file
        {
            StreamWriter writer = new StreamWriter(XMLurl);
            XmlSerializer xmlWriter = new XmlSerializer(XMLset.GetType());
            xmlWriter.Serialize(writer, XMLset);
            writer.Close();
        }

        private void GetXMLfile()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(XMLset.GetType());
            FileStream reader = new FileStream(XMLurl, FileMode.Open);

            XMLset = (DataSet) xmlSerializer.Deserialize(reader); // ------- mozhno e da treba try/catch ---------- Vo sluchaj da e corrupted fajlot
            reader.Close();
        }
    }
}
