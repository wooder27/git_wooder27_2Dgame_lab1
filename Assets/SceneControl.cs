using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace wooder.Tools
{
    /// <summary>
    /// 場景控制器 載入場景與退出場景
    /// </summary>
    public class SceneControl : MonoBehaviour
    {
        /// <summary>
        /// 載入場景
        /// </summary>
        /// <param name="sceneName">載入場景</param>
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        /// <summary>
        /// 退出場景
        /// </summary>
        public void QuitGame() //測試
        {
            Application.Quit();
        }
    }

}
