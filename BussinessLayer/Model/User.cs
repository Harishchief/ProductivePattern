namespace BussinessLayer.Model
{
    public class User
    {
        public virtual int UserId { get; set; }

        public virtual int ContactInfoId { get; set; }

        public virtual ContactInfo ContactInfo { get; set; }

        public virtual string UserName { get; set; }
    }
}