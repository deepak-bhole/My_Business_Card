using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkManager : MonoBehaviour
{
    public void OpenLinkedin()
        {
            Application.OpenURL("https://www.linkedin.com/in/deepak-bhole/");
        }
    public void OpenInstagram()
        {
            Application.OpenURL("https://www.instagram.com/b_deepak_07/");
        }
    public void OpenGithub()
        {
            Application.OpenURL("https://github.com/deepak-bhole");
        }
    public void OpenTwitter()
        {
            Application.OpenURL("https://twitter.com/bholedeep07");
        }
    public void Openyoutube()
        {
            Application.OpenURL("https://www.youtube.com/channel/UCqJM6z5agVcAydvHs0ts-uA");
        }

    public void DownloadResume()
    {
        Application.OpenURL("https://raw.githubusercontent.com/deepak-bhole/deepak-bhole.github.io/main/src/Resume/Deepak_Resume.pdf");
    }
    
}
