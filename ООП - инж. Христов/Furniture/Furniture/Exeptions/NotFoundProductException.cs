namespace Furniture.Exeptions
{
    public class NotFoundProductException : ApplicationException
    {
        public NotFoundProductException(string message) : base(message)
        {

        }
    }


}