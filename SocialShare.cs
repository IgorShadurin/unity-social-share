using UnityEngine;
using System.Collections;

public class SocialShare : MonoBehaviour
{
    public string Title;
    public string Description;
    public string Image;

    private string vkTemplate = "http://vk.com/share.php?title={0}&description={1}&image={2}&url={3}";
    private string facebookTemplate = "https://www.facebook.com/sharer/sharer.php?u={3}";
    private string odnoklassnikiTemplate = "http://www.odnoklassniki.ru/dk?st.cmd=addShare&st.s=1&st.surl={3}&st.comments={1}";
    private string twitterTemplate = "https://twitter.com/intent/tweet?text={0}&url={3}";

    private enum Social
    {
        VK,
        Facebook,
        Twitter,
        Odnoklassniki
    }

    string EscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }

    string makeUrl(Social social)
    {
        string template = string.Empty;

        string title = string.Empty;
        string description = string.Empty;
        string image = string.Empty;
        switch (social)
        {
            case Social.VK:
                template = vkTemplate;
                break;
            case Social.Facebook:
                template = facebookTemplate;
                break;
            case Social.Twitter:
                template = twitterTemplate;
                break;
            case Social.Odnoklassniki:
                template = odnoklassnikiTemplate;
                break;
            default:
                break;
        }

        return string.Format(template, EscapeURL(title), EscapeURL(description), EscapeURL(image));
    }

    public void VK()
    {
        string url = makeUrl(Social.VK);
        Publish(url);
    }

    public void Facebook()
    {
        string url = makeUrl(Social.Facebook);
        Publish(url);
    }

    public void Twitter()
    {
        string url = makeUrl(Social.Twitter);
        Publish(url);
    }

    public void Odnoklassniki()
    {
        string url = makeUrl(Social.Odnoklassniki);
        Publish(url);
    }

    void Publish(string url)
    {
        Application.OpenURL(url);
    }
}