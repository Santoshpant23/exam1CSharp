class LikeSystem
{

    public LikeSystem()
    {

    }

    public string getLikes(string[] arr)
    {
        if (arr.Length < 1)
        {
            string likes = "no one likes this";
            return likes;
        }
        else if (arr.Length == 1)
        {
            string name = arr[0];
            return name + " likes this";
        }
        else if (arr.Length == 2)
        {
            string name1 = arr[0];
            string name2 = arr[1];
            return name1 + " and " + name2 + " like this";
        }
        else if (arr.Length == 3)
        {
            string name1 = arr[0];
            string name2 = arr[1];
            string name3 = arr[2];
            return name1 + ", " + name2 + " and " + name3 + " like this";
        }
        else
        {
            int totalAfterFirstTwo = arr.Length - 2;
            string first = arr[0];
            string second = arr[1];
            return first + ", " + second + " and " + totalAfterFirstTwo + " others like this";
        }

    }


}