﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using wpf_samples_keyboard_tips.Data;

namespace wpf_samples_keyboard_tips
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            #region サンプルデータを設定
            this.SampleData = new ObservableCollection<SampleData>();
            this.SampleData.Add(new SampleData() { Name = "北海道", Hiragana = "ほっかいどう", Romaji = "hokkaido" });
            this.SampleData.Add(new SampleData() { Name = "青森", Hiragana = "あおもり", Romaji = "aomori" });
            this.SampleData.Add(new SampleData() { Name = "岩手", Hiragana = "いわて", Romaji = "iwate" });
            this.SampleData.Add(new SampleData() { Name = "宮城", Hiragana = "みやぎ", Romaji = "miyagi" });
            this.SampleData.Add(new SampleData() { Name = "秋田", Hiragana = "あきた", Romaji = "akita" });
            this.SampleData.Add(new SampleData() { Name = "山形", Hiragana = "やまがた", Romaji = "yamagata" });
            this.SampleData.Add(new SampleData() { Name = "福島", Hiragana = "ふくしま", Romaji = "fukushima" });
            this.SampleData.Add(new SampleData() { Name = "茨城", Hiragana = "いばらき", Romaji = "ibaraki" });
            this.SampleData.Add(new SampleData() { Name = "栃木", Hiragana = "とちぎ", Romaji = "tochigi" });
            this.SampleData.Add(new SampleData() { Name = "群馬", Hiragana = "ぐんま", Romaji = "gunma" });
            this.SampleData.Add(new SampleData() { Name = "埼玉", Hiragana = "さいたま", Romaji = "saitama" });
            this.SampleData.Add(new SampleData() { Name = "千葉", Hiragana = "ちば", Romaji = "chiba" });
            this.SampleData.Add(new SampleData() { Name = "東京", Hiragana = "とうきょう", Romaji = "tokyo" });
            this.SampleData.Add(new SampleData() { Name = "神奈川", Hiragana = "かながわ", Romaji = "kanagawa" });
            this.SampleData.Add(new SampleData() { Name = "新潟", Hiragana = "にいがた", Romaji = "niigata" });
            this.SampleData.Add(new SampleData() { Name = "富山", Hiragana = "とやま", Romaji = "toyama" });
            this.SampleData.Add(new SampleData() { Name = "石川", Hiragana = "いしかわ", Romaji = "ishikawa" });
            this.SampleData.Add(new SampleData() { Name = "福井", Hiragana = "ふくい", Romaji = "fukui" });
            this.SampleData.Add(new SampleData() { Name = "山梨", Hiragana = "やまなし", Romaji = "yamanashi" });
            this.SampleData.Add(new SampleData() { Name = "長野", Hiragana = "ながの", Romaji = "nagano" });
            this.SampleData.Add(new SampleData() { Name = "岐阜", Hiragana = "ぎふ", Romaji = "gifu" });
            this.SampleData.Add(new SampleData() { Name = "静岡", Hiragana = "しずおか", Romaji = "shizuoka" });
            this.SampleData.Add(new SampleData() { Name = "愛知", Hiragana = "あいち", Romaji = "aichi" });
            this.SampleData.Add(new SampleData() { Name = "三重", Hiragana = "みえ", Romaji = "mie" });
            this.SampleData.Add(new SampleData() { Name = "滋賀", Hiragana = "しが", Romaji = "shiga" });
            this.SampleData.Add(new SampleData() { Name = "京都", Hiragana = "きょうと", Romaji = "kyoto" });
            this.SampleData.Add(new SampleData() { Name = "大阪", Hiragana = "おおさか", Romaji = "osaka" });
            this.SampleData.Add(new SampleData() { Name = "兵庫", Hiragana = "ひょうご", Romaji = "hyogo" });
            this.SampleData.Add(new SampleData() { Name = "奈良", Hiragana = "なら", Romaji = "nara" });
            this.SampleData.Add(new SampleData() { Name = "和歌山", Hiragana = "わやかま", Romaji = "wakayama" });
            this.SampleData.Add(new SampleData() { Name = "鳥取", Hiragana = "とっとり", Romaji = "tottori" });
            this.SampleData.Add(new SampleData() { Name = "島根", Hiragana = "しまね", Romaji = "shimane" });
            this.SampleData.Add(new SampleData() { Name = "岡山", Hiragana = "おかやま", Romaji = "okayama" });
            this.SampleData.Add(new SampleData() { Name = "広島", Hiragana = "ひろしま", Romaji = "hiroshima" });
            this.SampleData.Add(new SampleData() { Name = "山口", Hiragana = "やまぐち", Romaji = "yamaguchi" });
            this.SampleData.Add(new SampleData() { Name = "徳島", Hiragana = "とくしま", Romaji = "tokushima" });
            this.SampleData.Add(new SampleData() { Name = "香川", Hiragana = "かがわ", Romaji = "kagawa" });
            this.SampleData.Add(new SampleData() { Name = "愛媛", Hiragana = "えひめ", Romaji = "ehime" });
            this.SampleData.Add(new SampleData() { Name = "高知", Hiragana = "こうち", Romaji = "kochi" });
            this.SampleData.Add(new SampleData() { Name = "福岡", Hiragana = "ふくおか", Romaji = "fukuoka" });
            this.SampleData.Add(new SampleData() { Name = "佐賀", Hiragana = "さが", Romaji = "saga" });
            this.SampleData.Add(new SampleData() { Name = "長崎", Hiragana = "ながさき", Romaji = "nagasaki" });
            this.SampleData.Add(new SampleData() { Name = "熊本", Hiragana = "くまもと", Romaji = "kumamoto" });
            this.SampleData.Add(new SampleData() { Name = "大分", Hiragana = "おおいた", Romaji = "oita" });
            this.SampleData.Add(new SampleData() { Name = "宮崎", Hiragana = "みやざき", Romaji = "miyazaki" });
            this.SampleData.Add(new SampleData() { Name = "鹿児島", Hiragana = "かごしま", Romaji = "kagoshima" });
            this.SampleData.Add(new SampleData() { Name = "沖縄", Hiragana = "おきなわ", Romaji = "okinawa" });
            #endregion 
        }


        private ObservableCollection<SampleData> _SampleData = new ObservableCollection<SampleData>();
        public ObservableCollection<SampleData> SampleData
        {
            get { return _SampleData; }
            set { _SampleData = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// プロパティ値の変更をクライアントに通知する。
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// PropertyChanged イベント を発生させる。
        /// </summary>
        /// <param name="propertyName">変更されたプロパティ名</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
