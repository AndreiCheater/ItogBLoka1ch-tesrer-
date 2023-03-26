#Array String Selection Method 
##Step 1. Add array
```C#
string[] vhod = {"vas", "oleg", "don", "1", "32", "peter", "q", "r", "g", "SDKFH", "gs", "sdfvnhad;lfjiopdhwifbhifdifjhifguwhfjhnfweuiofh"};
```
##Step 2.Create word count method
I made a method that counts words that are less than or equal to three symbols.
```C#
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
```
#Step 3. Create word selection method

Here I created a method that selects words less than or equal to three characters.
```C#
string Obhod (string[] vhod, int i)
{  
    string word;

    word = vhod[i];

    if (word.Length <= 3) return word;
    else return String.Empty;
}
```
#Step 4. Creating an array from selected words
This piece of code is made for compose an array selected words.
```C#
int i = 0;

    for (int j = 0; j < vhod.Length; j++)
    {
        string word = Obhod(vhod, j);
        if(word != String.Empty) 
        {
            itog[i] = word;
            i++;
        }
    }
    for (i = 0; i < itog.Length; i++)
    {
        Console.Write(itog[i] + " ");
    }
```



![Dog.logo](dog.jpg)