using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Character/New Character Config")]
public class CharacterConfig : ScriptableObject
{
    [Header("Character Info")]
    [Tooltip("Name of the character")]
    [SerializeField]
    private string _Name;
    public string Name => _Name;
    
    [Tooltip("Elemental affinity of the character")]
    [SerializeField]
    private PowerType _PowerType;
    public PowerType PowerType => _PowerType;

    [Tooltip("Team the character is on")]
    [SerializeField]
    private TeamType _TeamType;
    public TeamType TeamType => _TeamType;



    [Header("Art")]
    [Tooltip("Portrait Sprite")]
    [SerializeField]
    private Sprite _Portrait;
    public Sprite Portrait => _Portrait;


    [Header("Starting Stats")]
    [Tooltip("Whole number percentage of base damage reduction")]
    [SerializeField]
    private int _BaseMitigation = 0;
    public int BaseMitigation => _BaseMitigation;

    [Tooltip("Starting Hit Point Maximum")]
    [SerializeField]
    private int _BaseHP = 0;
    public int BaseHP => _BaseHP;

    [Tooltip("Starting Stagger Point Maximum")]
    [SerializeField]
    private int _BaseSP = 0;
    public int BaseSP => _BaseSP;

    [Tooltip("Base Attack Minimum Damage")]
    [SerializeField]
    private int _BaseAttackMin = 0;
    public int BaseAttackMin => _BaseAttackMin;

    [Tooltip("Base Attack Maximum Damage")]
    [SerializeField]
    private int _BaseAttackMax = 0;
    public int BaseAttackMax => _BaseAttackMax;
}
