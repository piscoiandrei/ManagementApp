namespace ManagementApp
{
    public class MyUser
    {
        public string id;
        public string email, fname, lname, pw;
        bool manager;
        public MyUser(string ID, string EMAIL, string FIRSTNAME, string LASTNAME, string PASSWORD)
        {
            id = ID;
            email = EMAIL;
            fname = FIRSTNAME;
            lname = LASTNAME;
            pw = PASSWORD;
        }
        public MyUser()
        {

        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }

        public string FIRSTNAME
        {
            get { return fname; }
            set { fname = value; }
        }

        public string LASTNAME
        {
            get { return lname; }
            set { lname = value; }
        }

        public string PASSWORD
        {
            get { return pw; }
            set { pw = value; }
        }

        public bool MANAGER
        {
            get { return manager; }
            set { manager = value; }
        }


    }
}
