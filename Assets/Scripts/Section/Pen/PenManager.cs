using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PenManager : SectionManager {
    public static PenManager selfInstance;
    public TextMeshProUGUI textBox;
    public GameObject options;

    private List<TextMeshProUGUI> textButtons = new List<TextMeshProUGUI>();
    private int currentIndex;
    private Queue<Word> words = new Queue<Word>();
    private int queueSize;

    public override void Awake() {
        base.Awake();

        Button[] optionButtons = options.GetComponentsInChildren<Button>();
        foreach (Button button in optionButtons) {
            textButtons.Add(button.GetComponentInChildren<TextMeshProUGUI>());
        }

        #region Singleton
        base.Awake();
        if (selfInstance == null) {
            selfInstance = this;
        }
        else {
            Destroy(gameObject);
        }
        #endregion
    }

    public override void ExecuteSection(SectionObject sectionObject) {

        PenObject penObject = (PenObject)sectionObject;

        foreach (Word word in penObject.words) {
            words.Enqueue(word);
        }

        textBox.text = penObject.text;
        textBox.ForceMeshUpdate(true);

        ExecuteNextWord();
    }

    private void ExecuteNextWord() {
        if (words.Count == 0) {
			ExitSection();
			return;
		}
		Word word = words.Dequeue();
        FocusWord(word);
    }

    private void FocusWord(Word word) {
        //string markedWord = textBox.textInfo.wordInfo[word.textIndex].GetWord();
        string markedWord = "<color=red>" + textBox.textInfo.wordInfo[word.textIndex].GetWord() + "</color>";
        currentIndex = word.textIndex;

        for (int i = 0; i < word.possibleValues.Length; i++) {
			textButtons[i].text = word.possibleValues[i];
        }

        ChangeWord(markedWord);
    }

    public override void HandleChoice(string text) {
        //ChangeWord(text);
        ExecuteNextWord();
    }

    private void ChangeWord(string word) {
        List<char> list = new List<char>(textBox.text.ToCharArray());

        int wordStart = textBox.textInfo.wordInfo[currentIndex].firstCharacterIndex;
        int wordEnd = textBox.textInfo.wordInfo[currentIndex].lastCharacterIndex + 1;

        list.RemoveRange(wordStart,wordEnd-wordStart);
        Debug.Log(new string(list.ToArray()));

        int i;
        for (i = 0; i < word.Length; i++) {
            list.Insert(wordStart + i, word[i]);
        }

        textBox.text = new string(list.ToArray());
    }
}
