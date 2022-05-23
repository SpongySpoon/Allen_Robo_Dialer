namespace Allen_Robo_Dialer
{
    abstract class Phone
    {

        private string _phoneNumber, _companyName;
        private int _phoneType;





        // 3-arg constructor
        public Phone(string phoneNumber, string companyName, int phoneType)
        {
            _phoneNumber = phoneNumber;
            _companyName = companyName;
            _phoneType = phoneType;
        }
        public string getNumber()
        {
            return _phoneNumber;
        }

        public string getName()
        {
            return _companyName;
        }

        public int getType()
        {
            return _phoneType;
        }


        public virtual string _Dial()
        {
            return _companyName + "is being dialed with " + _phoneNumber;
        }



    }
}
