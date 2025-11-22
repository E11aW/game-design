using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GamePlayButtons : MonoBehaviour
{
    public void OnQuitClick()
    {
        PlayerPrefs.Save();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void SaveData()
    {
        Slot[] slots = FindObjectsOfType<Slot>();

        foreach (Slot slot in slots)
        {
            if (slot.currentItem != null)
            {
                PlayerPrefs.SetString($"slot{slot.slotIndex}", slot.currentItem.itemID);
            }
            else
            {
                PlayerPrefs.DeleteKey($"slot{slot.slotIndex}");
            }
        }
        PlayerPrefs.Save();
    }

    public void LoadData()
    {
        Slot[] slots = FindObjectsOfType<Slot>();
        DraggableItem[] items = FindObjectsOfType<DraggableItem>();

        foreach (Slot slot in slots)
        {
            string key = $"slot{slot.slotIndex}";
            if (PlayerPrefs.HasKey(key))
            {
                string itemID = PlayerPrefs.GetString(key);
                foreach (DraggableItem item in items)
                {
                    if (item.itemID == itemID)
                    {
                        item.transform.SetParent(slot.transform);
                        item.transform.localPosition = Vector3.zero;
                        slot.currentItem = item;
                        break;
                    }
                }
            }
            else
            {
                slot.currentItem = null;
            }
        }
    }
}
