# 授業で使える、学生あてのくじ引き

授業で、人を当てるときに、生徒から不満が上がることがアルと思います。
そんな悩みを解決してくれるツールです！！

授業で使って生徒からの評判を良くしましょう！！

# プログラムの使用方法
1. ダウンロードします
1. Lottery.slnをクリックします。
1. VisualStudioが起動します。
1. CtrlとF5を押して、デバックなしで実行してください。
1. そうすることで、プログラムを使用可能です。
1. ２回目以降は、Lottery/Lottery/bin/Debug ないにあるLottery.exeを起動していただければ、実行可能です。
### 注意事項
実行した後に出てくるウィンドウは、**「授業が終わるまで」** 消さないでください。  
消してしまうとリセットがかかってしまい、授業中に同じ人を当ててしまう可能性があるためです。



# プログラムの使用イメージ
![](./images/usecase.png)

# プログラムのイメージ図
![](./images/activity.png)

# クラスの名簿の変え方
1. Lottery/Lottery/bin/ClassDataCSV に入っているCSVファイルに生徒名などのデータを変更します。
1. 実行し、新しく追加したフォルダを選択すると新しいクラスが使えます。

# 表示する写真の変更方法
1. 表示する写真は、Lottery/Lottery/01Image内の写真になっています。
1. 写真は、20枚入っています。
1. そのフォルダ内に入っている写真を変更する形でお願いします。

### 注意事項
縦長の写真にすると、縮尺がおかしくなるので、横長(16:9などの縦横比)の写真を入れるようにしてください。
写真名は、「Back数字.jpg」という形にしてください。





# 参考文献
1. [チュートリアル](https://plantuml.com/ja/)
1. [ユースケース図](https://plantuml.com/ja/use-case-diagram)
1. [シーケンス図](https://plantuml.com/ja/sequence-diagram)
1. [【C#入門】停止は「Thread.Sleep」よりも「Task.Delay」を使う](https://www.sejuku.net/blog/54567)
1. [Windows フォーム Label コントロールのサイズを内容に合わせて変更する](https://docs.microsoft.com/ja-jp/dotnet/desktop/winforms/controls/how-to-size-a-windows-forms-label-control-to-fit-its-contents?view=netframeworkdesktop-4.8)
1. [Random クラス](https://docs.microsoft.com/ja-jp/dotnet/api/system.random?view=net-5.0)
1. [C#：コンボボックスの使い方](https://dianxnao.com/csコンボボックスの使い方/)
1. [C＃ラジオボタンとグループボックス](https://anderson02.com/cs/winforms/post-142/)
1. [C# ラジオボタンの作成のサンプル(フォームアプリケーション)](https://itsakura.com/csharp-form-radiobutton)
1. [Control.Visible プロパティ](https://docs.microsoft.com/ja-jp/dotnet/api/system.windows.forms.control.visible?view=net-5.0)
1. [RadioButtonのチェック状態を取得する - C#プログラミング](https://www.ipentec.com/document/csharp-using-radiobutton)
1. [コンボボックス（ComboBoxコントロール）を読み取り専用にするには？［C#、VB］](https://www.atmarkit.co.jp/ait/articles/0711/01/news152.html)
1. [Array.Resize<T>(T[], Int32) メソッド](https://docs.microsoft.com/ja-jp/dotnet/api/system.array.resize?view=net-5.0)
1. [ComboBox.ObjectCollection.AddRange(Object[]) メソッド](https://docs.microsoft.com/ja-jp/dotnet/api/system.windows.forms.combobox.objectcollection.addrange?view=net-5.0)
1. [Directory.GetFiles メソッド](https://docs.microsoft.com/ja-jp/dotnet/api/system.io.directory.getfiles?view=net-5.0)
1. [コンボボックスに項目を追加する - コンボボックスのドロップダウンリストに追加する - C#プログラミング](https://www.ipentec.com/document/csharp-combobox-add-item)