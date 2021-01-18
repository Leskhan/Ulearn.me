public static string ReplaceIncorrectSeparators(string text)
{
	  string[] s = { " ", ":", ";", "-", "," };
    var t = text.Split(s, StringSplitOptions.RemoveEmptyEntries);
    return String.Join("\t", t);
}
