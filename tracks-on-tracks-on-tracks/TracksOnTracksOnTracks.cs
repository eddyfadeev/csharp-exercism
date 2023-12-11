using System;
using System.Collections.Generic;

public static class Languages
{
    private static List<string> listOfLanguages;
    public static List<string> NewList() => new List<string>();

    public static List<string> GetExistingLanguages()
    {
        List<string> listOfLanguages = NewList();
        
        listOfLanguages.Add("C#");
        listOfLanguages.Add("Clojure");
        listOfLanguages.Add("Elm");

        return listOfLanguages;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);

        return languages;
    }

    public static int CountLanguages(List<string> languages) => languages.Count;

    public static bool HasLanguage(List<string> languages, string language) => languages.Contains(language);

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();

        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        foreach (var language in languages)
        {
            if (languages[0].Contains("C#"))
                return true;
            if (languages[1].Contains("C#") && (languages.Count >= 2 && languages.Count <= 3))
                return true;
        }
        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);

        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        for(int i = 0; i < languages.Count; i++)
        {
            for(int j = i + 1; j < languages.Count; j++)
            {
                if (languages[i] == languages[j])
                    return false;
            }
        }

        return true;
    }
}
