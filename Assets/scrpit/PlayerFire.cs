using UnityEngine;

namespace KIDSU
{
    /// <summary>
    /// ���a�g���t��
    /// </summary>
    public class PlayerFire : FireSystem
    {
        //�������a�欰:��L�A�ƹ��AĲ���P�n��
        private void Update()
        {
            // �p�G ���a ���U�ťի� �N �ͦ��l�u
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                SpawnBullet();

            }

        }
    }
}
