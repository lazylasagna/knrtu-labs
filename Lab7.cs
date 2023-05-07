public static void Main() {
    string text = File.ReadAllText(@ "D:\\text.txt");
    int k = 1;
    string l = "";
    string l1 = "";
    for (int i = 0; i < text.Length; i++) {
      if (text[i] == '.') {
        k = 1;
        l += l1;
      }
      if (text[i] == ',') {
        k = 0;
        l1 = "";
      }
      if (k != 0) l1 += text[i];
    }
    Console.WriteLine(l);
    File.WriteAllText(@ "D:\text2.txt", "");
    string[] w = File.ReadAllText("D:\\text1.txt").Split(new char[] {
      ' ',
      '\n'
    });
    List < string > s = new List < string > ();
    List < string > v = new List < string > ();
    for (int i = 1; i < w.Length; i += 2) {
      s.Add(w[i]);
      v.Add(w[i]);
    }
    foreach(string s2 in s) {
      int count = 0;
      while (v.Contains(s2)) {
        count++;
        v.Remove(s2);
      }
      if (count > 0) {
        File.AppendAllText(@ "D:\text2.txt", s2 + "\n");
        File.AppendAllText(@ "D:\text2.txt", Convert.ToString(count) + "\n");
      }
    }
