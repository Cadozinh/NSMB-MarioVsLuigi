using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;

[CreateAssetMenu(fileName = "WholeStringRegexValidator", menuName = "ScriptableObjects/WholeStringRegexValidator")]
public class WholeStringRegexValidator : TMP_InputValidator {
    public string pattern;
    public override char Validate(ref string text, ref int pos, char ch) {
        Debug.Log($"text={text} ch={ch} combined={text+ch} against regex={pattern}");
        if (Regex.IsMatch(text + ch, pattern)) {
            text = text.Insert(pos, ch.ToString());
            pos++;
            return ch;
        }

        return (char) 0;
    }
}