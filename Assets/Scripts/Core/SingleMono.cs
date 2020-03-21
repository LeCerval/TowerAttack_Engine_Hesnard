using UnityEngine;

public class SingleMono<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T m_Instance;

    public static T Instance
    {
        get
        {
            if(m_Instance == null)
            {
                m_Instance = FindObjectOfType<T>();

                if(m_Instance == null)
                {
                    GameObject newInstanceGO = new GameObject("[Singleton]" + nameof(T));
                    m_Instance = newInstanceGO.AddComponent<T>();
                }
            }
            return m_Instance;

        }
    }
    
    
}
