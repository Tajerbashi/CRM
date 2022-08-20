using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
using BEE;


namespace BLL
{
    public class UserBLL
    {
        private String Encode(String Pass)
        {
            byte[] encData_byte = new byte[Pass.Length];
            encData_byte = System.Text.Encoding.UTF8.GetBytes(Pass);
            String encodedData=Convert.ToBase64String(encData_byte);
            return encodedData;
        }
        private String Decode(String Encode)
        {
            System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
            System.Text.Decoder enc2 = enc.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(Encode);
            int charCount = enc2.GetCharCount(todecode_byte,0,todecode_byte.Length);
            char[] decode_char= new char[charCount];
            enc2.GetChars(todecode_byte,0,todecode_byte.Length,decode_char,0);
            String Result=new string(decode_char);
            return Result;
        }
        UserDAL dal = new UserDAL();

        public bool Create(User user,String NameUg)
        {
            user.Password = Encode(user.Password);
            return dal.Create(user, NameUg);
        }
        public DataTable ReadAll()
        {
            return dal.ReadAll();
        }
        public User ReadByID(int id)
        { 
            return dal.ReadByID(id);
        }
        public User ReadByUserName(String user)
        {
            return dal.ReadByUserName(user);
        }
        public List<string> ReadUserByName()
        {
            return (dal.ReadUserbyName()).ToList();
        }
        public List<string> ReadUserbyUserName()
        {
            return (dal.ReadUserbyUserName()).ToList();
        }
        public bool Update(User user, int id)
        {
            user.Password = Encode(user.Password);
            return dal.Update(user, id);
        }
        public bool Delete(int id)
        {
            return dal.Delete(id);
        }
        public bool IsAdmin()
        {
            return dal.IsAdmin();
        }
        public User IsLogin(String username, String pass)
        {
            pass = Encode(pass);
            return dal.IsLogin(username,pass);
        }
        public bool Access(User user, String S, int a)
        {
            //  1 Can Enter            //  2 Can Create            //  3 Can Update            //  4 Can Delete
            return dal.Access(user, S, a);
        }
    }
}
