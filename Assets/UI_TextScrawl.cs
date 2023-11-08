using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_TextScrawl : MonoBehaviour
{
    CombatReferee _ref;
    TextMeshProUGUI _text;
    void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        // TODO: Let's let the UIManager sort out getting this ref.
        _ref = GameObject.Find("Combat Field").GetComponent<CombatReferee>();
        _ref.eventProvider.OnAnnouncedEvent += HandleAnnouncedEvent;
    }

    void HandleAnnouncedEvent(string announcement) {
        _text.text = announcement;
    }
}
