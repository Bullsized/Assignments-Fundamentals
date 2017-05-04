using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Social_Media_Posts
{
    class Program
    {
        static void Main(string[] args)
        {
            var likesDict = new Dictionary<string, int>();
            var dislikesDict = new Dictionary<string, int>();
            var commentsDict = new Dictionary<string, List<string>>();

            string inputPost = Console.ReadLine();

            while (inputPost != "drop the media")
            {
                var separateThePosts = inputPost.Split().ToList();
                string typeOfPost = separateThePosts[0];
                string postName = separateThePosts[1];

                if (typeOfPost == "post")
                {
                    likesDict.Add(postName, 0);
                    dislikesDict.Add(postName, 0);
                    commentsDict.Add(postName, new List<string>());
                }
                else if (typeOfPost == "like")
                {
                    likesDict[postName]++;
                }
                else if (typeOfPost == "dislike")
                {
                    dislikesDict[postName]++;
                }
                else
                {
                    var additionalComments = separateThePosts.GetRange(3, separateThePosts.Count - 3);

                    commentsDict[postName].Add($"*  {separateThePosts[2]}: {string.Join(" ", additionalComments)}");
                }

                inputPost = Console.ReadLine();
            }


            foreach (var postName in likesDict)
            {
                Console.WriteLine("Post: {0} | Likes: {1} | Dislikes: {2}",
                    postName.Key,
                    postName.Value,
                    dislikesDict[postName.Key]);
                Console.WriteLine("Comments:");
                if (commentsDict[postName.Key].Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var comments in commentsDict[postName.Key])
                    {
                        Console.WriteLine(comments);
                    }
                }
            }
        }
    }
}