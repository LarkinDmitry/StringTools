using UnityEngine;

namespace KAKuBCE.SimpleTranslator
{
    public class SimpleTranslationInitializer : MonoBehaviour
    {
        [SerializeField] private Language devLanguage;
        [Space]
        [SerializeField] private Language[] supportLanguages;

        private void Awake()
        {
            StringLocalizator.Initialization(devLanguage, supportLanguages);
            StringLocalizator.SetTranslateLanguage(devLanguage);
        }
    }
}