using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Animations;

public class SpriteSliceEditClass
{
    /// <summary>
    /// TextureImporter��spritesheet�̒��ɂ���X�v���C�g���ׂĂ�pivot��ݒ肵�܂��B
    /// </summary>
    public void SetPivotsAll(string path, TextureImporter textureImporter, float x, float y)
    {
        textureImporter.isReadable = true;// �ǂݍ��݁E�������݂�L����
        for (int i = 0; i < textureImporter.spritesheet.Length; i++)
        {
            textureImporter.spritesheet[i].alignment = (int)SpriteAlignment.Custom;
            textureImporter.spritesheet[i].pivot = new Vector2(x, y);
        }
        /*�ҏW�������e��Meta�t�@�C���𔽉f*/
        AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
    }

    /// <summary>
    /// TextureImporter��spritesheet�̒��ɂ���X�v���C�g���ׂĂ�z�u����AnimationClip���쐬���܂��B
    /// </summary>
    public void SpritesToAnimationAll(SpriteMetaData[] spriteSheet, Animator animator, float intervalTime)
    {
        AnimationClip animationClip = new AnimationClip();

        // �ȉ��ɃX�v���C�g�̃t�@�C���p�X���擾���ăL�[��ł����A�j���[�V�����J�[�u���쐬�A���̃J�[�u���N���b�v�ɉ�����\��
    }
}
