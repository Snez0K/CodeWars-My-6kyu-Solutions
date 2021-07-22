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

string result = "www.codewars.com/katas/?page=1#about";
            //Regex regex = new Regex(@"\#.+");
            Regex regex = new Regex(@"^[1][ .-]|^0039[ .-]|^+39[ .-]");
            Regex back = new Regex(@"[ .-][0-9]{3}[ .-][0-9]{3}[ .-][0-9]{4}");
            Regex replace = new Regex(@"[0-9]");

            //string boy = regex.Match(result).Success ? back.Match(result).Success ? Regex.Replace(result, replace ) : "DoubleGay" : "Gay";

            string boy = regex.Match(result).Success ? back.Match(result).Success ? result. : "DoubleGay" : "Gay";
            //string boy = regex.Match(result).Success ? result.Replace(regex.Match(result).Value, "") : "Gay";

            //string boy = regex.Match(result).Value;
            //Console.WriteLine(boy);
