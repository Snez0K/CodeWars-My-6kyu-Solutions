/*You need to hide subscribers' phone numbers and check their prefixes in order to send the encrypted file to a client.

Your tasks are:

to hide the last six digits of each phone number
to check validity of prefixes
Example 1
Original phone number	Encrypted
1-201-680-0202	1-201-6XX-XXXX
The valid formats for the Italian and US (the last one) numbers are the following:

CASE 1: +39 <separator> ### <separator> ### <separator> ####

CASE 2: 0039 <separator> ### <separator> ### <separator> ####

CASE 3: 1 <separator> ### <separator> ### <separator> ####

The list of separators is the following:

for Italian numbers: " ", ".", ""
for US numbers: " ", ".", "", "-"*/


///WIP WIP WIP WIP WIP FOR SOLUTION WIP WIP WIP WIP
static void Main(string[] args)
        {
            string result = "+39 328 6587120";
            Regex regex = new Regex(@"^[1][ .-]|^0039[ .-]|^\+39[ .-]");
            Regex back = new Regex(@"[ .-][0-9]{3}[ .-][0-9]{3}[ .-][0-9]{4}|[ .-][0-9]{7}");

            char[] boy = regex.Match(result).Success ? back.Match(result).Success ? result.ToCharArray() : "SecondFalse".ToCharArray() : "False".ToCharArray(); //Там где X оно реплейсит все
            int temp = 6;

            for (int i = boy.Length - 1; i > 0; i--)
            {
                if (temp == 0)
                {
                    break;
                }
                if (char.IsDigit(boy[i]))
                {
                    boy[i] = 'X';
                    temp--;
                }
            }

            for (int b = 0; b < boy.Length; b++)
            {
                Console.Write(boy[b]);
            }
