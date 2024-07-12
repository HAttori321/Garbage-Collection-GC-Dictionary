namespace Garbage_Collection__GC___Dictionary
{
    public class PhoneBook<TKey, TValue>
    {
        private Dictionary<TKey, TValue> _phoneBook;
        public PhoneBook()
        {
            _phoneBook = new Dictionary<TKey, TValue>();
        }
        public void Add(TKey key, TValue value)
        {
            if (_phoneBook.ContainsKey(key))
            {
                throw new ArgumentException("Key already exists in the phone book");
            }
            _phoneBook.Add(key, value);
        }
        public void Update(TKey key, TValue value)
        {
            if (!_phoneBook.ContainsKey(key))
            {
                throw new ArgumentException("Key does not exist in the phone book");
            }
            _phoneBook[key] = value;
        }
        public TValue Get(TKey key)
        {
            if (!_phoneBook.TryGetValue(key, out TValue value))
            {
                throw new ArgumentException("Key does not exist in the phone book");
            }
            return value;
        }
        public void Remove(TKey key)
        {
            if (!_phoneBook.ContainsKey(key))
            {
                throw new ArgumentException("Key does not exist in the phone book");
            }
            _phoneBook.Remove(key);
        }
        public void Clear()
        {
            _phoneBook.Clear();
        }
        public int Count
        {
            get { return _phoneBook.Count; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook<string, string> phoneBook = new PhoneBook<string, string>();
            phoneBook.Add("Juma Jama", "0967435892");
            phoneBook.Add("Guma Gama", "0987654321");
            Console.WriteLine(phoneBook.Get("Juma Jama"));
            phoneBook.Update("Juma Jama", "555666777888");
            Console.WriteLine(phoneBook.Get("Juma Jama"));
            phoneBook.Remove("Guma Gama");
            Console.WriteLine(phoneBook.Count);
            phoneBook.Clear();
            Console.WriteLine(phoneBook.Count);
        }
    }
}
