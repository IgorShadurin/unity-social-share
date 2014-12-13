using UnityEngine;
using System.Collections;

public class SocialShare : MonoBehaviour
{
    public string VkTitle;
    public string VkDescription;
    public string VkImage;

    string EscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }

    public void VK()
    {
        /// www
        string url = string.Empty;
        url = string.Format("http://vk.com/share.php?title={1}{0}&description={2}{0}.{3}&image=&url=http://www.windowsphone.com/s?appid=308aa220-1bf0-4857-8bb1-3c050fd9a6a0", 123, EscapeURL("Примерный возраст смерти: "), EscapeURL("Мой предположительный возраст смерти: "), EscapeURL(" Пройди тест на своем Windows Phone"));
#if UNITY_METRO
        url = string.Format("http://vk.com/share.php?title=Примерный возраст смерти: {0}&description=Мой предположительный возраст смерти: {0}. Пройди тест на компьютере с Windows 8&image=&url=", TestMaker.resultYears);        
#endif

        Application.OpenURL(url);
    }

    public void Facebook()
    {
        whahah
    }

    public void Twitter()
    {

    }
}