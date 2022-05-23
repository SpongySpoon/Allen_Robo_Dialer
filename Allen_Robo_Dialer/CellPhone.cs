namespace Allen_Robo_Dialer
{

    class CellPhone : Phone
    {

        public CellPhone(string companyName, string phoneNumber, int phoneType) : base(phoneNumber, companyName, phoneType)
        {
            

        }
      




        public override string _Dial()
        {
            
            return getName() + "is being dialed using 1+ " + getNumber() + "...";

        }
    }
}
