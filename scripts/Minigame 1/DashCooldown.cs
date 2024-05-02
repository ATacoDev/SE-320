using UnityEngine;
using UnityEngine.UI;

public class DashCooldown : MonoBehaviour
{
    public Image cooldownImage;
    public float cooldownTime = 1.5f;

    private float coolDownTimer;

    private void Start()
    {
        cooldownImage.fillAmount = 1;
        coolDownTimer = cooldownTime;
    }

    private void Update()
    {
        if (coolDownTimer < cooldownTime)
        {
            coolDownTimer += Time.deltaTime;
            cooldownImage.fillAmount = coolDownTimer / cooldownTime;
        }
    }

    public void StartCooldown()
    {
        cooldownImage.fillAmount = 0;
        coolDownTimer = 0;
    }
}
