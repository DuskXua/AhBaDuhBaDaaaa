using UnityEditor;

[CustomEditor(typeof(Interactable), true)]
public class InteractableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Interactable interactable = (Interactable)target;
        if (target.GetType() == typeof(EventOnlyInteractable))
        {
            interactable.PromptText = EditorGUILayout.TextField("Prompt Message", interactable.PromptText);
            EditorGUILayout.HelpBox("EventOnlyInteractable can ONLY use UnityEvents", MessageType.Info);
            if(interactable.GetComponent<InteractionEvent>() == null)
                interactable.gameObject.AddComponent<InteractionEvent>();
        }
        else
        {
            base.OnInspectorGUI();
            if (interactable.useEvents)
            {
                if (interactable.GetComponent<InteractionEvent>() == null)
                    interactable.gameObject.AddComponent<InteractionEvent>();

            }
            else
            {
                if(interactable.GetComponent<InteractionEvent>() != null)
                {
                    DestroyImmediate(interactable.GetComponent<InteractionEvent>());
                }
            }
        }
    }
}
