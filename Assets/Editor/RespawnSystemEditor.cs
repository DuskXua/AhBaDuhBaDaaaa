using UnityEditor;

[CustomEditor(typeof(RespawnSystem))]
public class RespawnSystemEditor : Editor
{
    public override void OnInspectorGUI()
    {
        RespawnSystem sys = (RespawnSystem)target;

        if (sys.RespawnPlayerAtDepth)
        {
            if (sys.GetComponent<RespawnPlayerAtDepth>() == null)
                sys.gameObject.AddComponent<RespawnPlayerAtDepth>();

        }
        else
        {
            if (sys.GetComponent<RespawnPlayerAtDepth>() != null)
            {
                DestroyImmediate(sys.GetComponent<RespawnPlayerAtDepth>());
            }
        }
        base.OnInspectorGUI();
    }
}
