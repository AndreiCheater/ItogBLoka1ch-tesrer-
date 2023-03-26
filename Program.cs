string[] vhod = {"vas", "oleg", "don", "1", "32", "peter", "q", "r", "g", "SDKFH", "gs", "sdfvnhad;lfjiopdhwifbhif;difjhifguwhfjhnfweuiofh"};
string[] itog = new string[Count(vhod)];

int Count (string[] vhod)
{
    int count = 0;
    for (int i = 0; i < vhod.Length; i++)
    {
        string word;
        word = vhod[i];
        if (word.Length <= 3) count++;
    }
    return count;
}

string Obhod (string[] vhod, int i)
{  
    string word;

    word = vhod[i];

    if (word.Length <= 3) return word;
    else return String.Empty;
}