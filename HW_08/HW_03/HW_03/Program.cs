string addresses = "123 Main St.Louisville OH 43071,432 Main Long Roald St.Louisville OH 43071,768 High Streat Pollochsville NY 56432";

Console.WriteLine(Travel(addresses, "OH 43071"));
Console.WriteLine(Travel(addresses, "NY 56432"));

// 123 Main St.Louisville OH 43071,432 Main Long Road St.Louisville OH 43071
// OH 43071:Main St.Louisville,Main Long Road St.Louisville/123,432
// OH 123:/
static string Travel(string addresses, string zipcode)
{
    string streets = string.Empty;
    string numbers = string.Empty;

    string[] array = addresses.Split(',');

    foreach (var address in array)
    {
        //123 Main St.Louisville OH 43071
        string[] parts = address.Split(' ');
        string code = parts[parts.Length - 2] + " " + parts[parts.Length - 1];

        if (code == zipcode)
        {
            string number = parts[0];
            if (numbers == string.Empty)
            {
                numbers = number;
            }
            else
            {
                numbers += "," + number;
            }

            string street = address.Replace(number, "").Replace(code, "");
            street = street.Trim();

            if (streets == string.Empty)
            {
                streets = street;
            }
            else
            {
                streets += "," + street;
            }

        }
    }
    return zipcode + ":" + streets + "/" + numbers;
}