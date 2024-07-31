using FunWithBytes;

Console.WriteLine("****** Fun With Bitwise Operations ******");

Console.WriteLine("6 & 4 =  {0} | {1}", 6 & 4, Convert.ToString(6 & 4, 2));
Console.WriteLine("6 | 4 =  {0} | {1}", 6 | 4, Convert.ToString(6 | 4, 2));
Console.WriteLine("6 ^ 4 =  {0} | {1}", 6 ^ 4, Convert.ToString(6 ^ 4, 2));
Console.WriteLine("6 >> 4 =  {0} | {1}", 6 >> 4, Convert.ToString(6 >> 4, 2));
Console.WriteLine("6 << 4 =  {0} | {1}", 6 << 4, Convert.ToString(6 << 4, 2));
Console.WriteLine("~6 =  {0} | {1}", ~6, Convert.ToString(~((short)6), 2));
Console.WriteLine("Int.MaxValue {0}", Convert.ToString(int.MaxValue, 2));

ContactPreferenceEnum emailAndPhone = ContactPreferenceEnum.Email | ContactPreferenceEnum.Phone;

Console.WriteLine("None? {0}", (emailAndPhone | ContactPreferenceEnum.None) == emailAndPhone);
Console.WriteLine("Email? {0}", (emailAndPhone | ContactPreferenceEnum.Email) == emailAndPhone);
Console.WriteLine("Phone? {0}", (emailAndPhone | ContactPreferenceEnum.Phone) == emailAndPhone);
Console.WriteLine("Text? {0}", (emailAndPhone | ContactPreferenceEnum.Text) == emailAndPhone);