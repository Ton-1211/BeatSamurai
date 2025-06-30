using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SpritePivotSetter : EditorWindow
{
    //[MenuItem("Butadon'sTool/�ꊇpivot�ݒ�")]
    static void Open()
    {
        EditorWindow.GetWindow<SpritePivotSetter>("�ꊇpivot�ݒ�");
    }

    Texture2D texture = null;
    float x = 0f;
    float y = 0f;
    SpriteSliceEditClass spriteSliceEdit = new SpriteSliceEditClass();

    private void OnGUI()
    {
        EditorGUILayout.LabelField("�w�肵���ꏊ��pivot���X�v���C�g�̃X���C�X���ׂĂɈꊇ�Őݒ肵�܂�");

        texture = (Texture2D)EditorGUILayout.ObjectField("Texture", texture, typeof(Texture2D), true);

        EditorGUILayout.LabelField("pivot�̈ʒu�ݒ�");
        x = EditorGUILayout.Slider("x", x, 0f, 1f);// 0�`1�͈̔͂ɐ���
        y = EditorGUILayout.Slider("y", y, 0f, 1f);

        if (GUILayout.Button("pivot��ݒ�"))
        {
            SettingPivot(texture);
        }
    }

    private void SettingPivot(Texture2D texture)
    {
        string path = AssetDatabase.GetAssetPath(texture);
        TextureImporter ti = AssetImporter.GetAtPath(path) as TextureImporter;

        spriteSliceEdit.SetPivotsAll(path, ti, x, y);
    }
}
