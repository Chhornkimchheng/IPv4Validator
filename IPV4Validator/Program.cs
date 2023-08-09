namespace IPV4Validator
{
    class Program
    {
        static bool IsValidIPv4Address(string ipAddress)
        {
            string[] octets = ipAddress.Split('.');

            if (octets.Length != 4)
                return false;

            foreach (string octet in octets)
            {
                if (!int.TryParse(octet, out int value) || value < 0 || value > 255 || (octet.Length > 1 && octet[0] == '0'))
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter an IPv4 address: ");
            string ipAddress = Console.ReadLine();

            bool isValid = IsValidIPv4Address(ipAddress);

            if (isValid)
            {
                Console.WriteLine("Valid IPv4 address.");
            }
            else
            {
                Console.WriteLine("Invalid IPv4 address.");
            }
        }
    }
}