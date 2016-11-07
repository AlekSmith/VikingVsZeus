using UnityEngine;
using System.Collections;

public class sharescript : MonoBehaviour {
     /// <summary>
    /// Камера в которую будет тыкать пользователь
    /// </summary>
    public Camera MyCamera;

    /// <summary>
    /// Cсылка на ваше приложение, которым пользователь будет делиться
    /// </summary>
    public string ApplicationLink = "https://play.google.com/store/apps/details?id=com.Exlain.Paranoia_Fox";

    /// <summary>
    /// Заголовок поста
    /// </summary>
    public string Title = "Paranoia Fox | Лисичка Паранойя";

    /// <summary>
    /// Содержание поста
    /// </summary>
    public string Description =
            "Помоги Лисичке Паранойе не попасть под чары грибов и странной воды, и собери как можно больше яблок!";

    /// <summary>
    /// Ссылка на логотип игры
    /// </summary>
    public string ImageUrl = "http://5665tm.ucoz.ru/1234/ico.png";

    // Update is called once per frame
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = MyCamera == null
                    ? Camera.main.ScreenPointToRay(Input.mousePosition)
                    : MyCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.name == gameObject.name)
                {
                    Application.OpenURL("http://m.vk.com/share.php?url=" + ApplicationLink
                                                            + "&title=" + Title
                                                            + "&description=" + Description
                                                            + "&image=" + ImageUrl);
                }
            }
        }
    }
}
