using System.Collections;

class SearchInArray
{

    public SearchInArray()
    {

    }




    public string[] searchParts(string[] parents, string child)
    {


        ArrayList found = new ArrayList();

        for (int i = 0; i < parents.Length; i++)
        {
            string toCheck = parents[i].ToLower();
            if (toCheck.Contains(child))
            {
                found.Add(parents[i]);
            }
        }


        if (found.Count < 1)
        {
            return new string[] { "Empty" };
        }
        else
        {
            string[] ans = new string[found.Count];
            int count = 0;
            foreach (string str in found)
            {
                ans[count] = str;
                count++;
            }

            return ans;
        }


    }


}