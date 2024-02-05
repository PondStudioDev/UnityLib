using UnityEngine;

public class ResourceManager
{
    public T Load<T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }

    public GameObject Instantiate(string path, Transform parent = null)
    {
        GameObject prefab = Load<GameObject>($"Prefabs/{path}");
        if (prefab == null)
        {
            Debug.Log($"Failed to load prefab : {path}");
            return null;
        }

        GameObject go = Object.Instantiate(prefab, parent);

        int index = go.name.IndexOf("(Clone)");
        go.name = index > 0 ? go.name.Remove(index) : go.name;

        return go;
    }

    public void Destroy(GameObject go) 
    {
        if (go == null)
            return;
        Object.Destroy(go);
    }
}
