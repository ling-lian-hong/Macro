using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algorithm : MonoBehaviour {
    // Use this for initialization
    int[] arr = { 2, 3, 5, 3, 4, 8, 6, 7 };
    void Start() {

       // LinkedTest();
        // int value = FindSameAlgorithm(arr);
        //Debug.Log(value);
        //  Methoed(arr);

        //int a = 4 + 12;
        //for (int i = 0; i < 10; i++)
        //{
        //    Debug.Log(i+">>2: "+(i>>2));
        //    Debug.Log(i+"<<2: " + (i <<2));
        //}       

        //Sort(arr, 1, 8);
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Debug.Log(arr[i]);
        //}
        //RemoveTheagain01(arr);
    }


    #region 数组查重
    [ContextMenu("数组查重")]
    void ArryFindSame() {
        int value = FindSameAlgorithm(arr);
        Debug.Log(value);
    }

    int FindSameAlgorithm(int[] arr)
    {
        int[] newArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0 || arr[i] >= arr.Length)
                Debug.Log("输入参数不合法");
            // throw new IllegalArgumentException("输入参数不合法");
            else
                newArr[i] = -1;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log("newArr[arr[i]]" + newArr[arr[i]]);
            if (newArr[arr[i]] != arr[i])
            {
                newArr[arr[i]] = arr[i];
            }
            else
            {
                Debug.Log(arr[i]);
                // return arr[i];

            }

        }
        return -1;

    }

    #endregion

    int Methoed(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int count = 0;
            while (arr[i] != 1)
            {
                count++;
                Debug.Log(count);
                if (count > 100)
                    break;
                if (arr[i] == arr[arr[i]])
                {
                    //cout << arr[i] << endl;
                    //exit(0);
                    return arr[i];
                }

                //交换
                int temp = arr[i];
                arr[i] = arr[arr[i]];
                arr[arr[i]] = temp;
                // Swap(arr[i], arr[arr[i]]);

            }
        }
        return -1;
    }

    //交换数据
    private void swap(ref int l, ref int r)
    {
        int temp;//临时值
        temp = l;//记录前一个值
        l = r;//记录后一个值
        r = temp;//前后交换数据
    }
    private void Sort(int[] list, int low, int high)
    {
        int pivot;//临时变量，用来存储最大值
        int l, r;//分别用来记录遍历到的索引和最大索引
        int mid;//中间索引
        if (high <= low)//判断输入的值是否合法
            return;
        else if (high == low + 1)//判断两个索引是否相邻
        {
            if (list[low] > list[high])//判断前面的值是否大于后面的值
                swap(ref list[low], ref list[high]);//交换前后索引的值
            return;
        }
        mid = (low + high) >> 1;//记录数组的中间索引,相当于(low + high)除以2
        pivot = list[mid];//初始化临时变量的值
        swap(ref list[low], ref list[mid]);//交换第一个值和中间值的索引顺序
        l = low + 1;//记录遍历到的索引值
        r = high;//记录最大索引
        try
        {
            //使用do...while循环遍历数组，并比较前后值的大小
            do
            {

                while (l <= r && list[l] < pivot)//判断遍历到的索引是否小于最大索引
                    l++;//索引值加1
                while (list[r] >= pivot)//判断最大值是否大于等于记录的分支点
                    r--;//做大索引值减1
                if (l < r)//如果当前遍历到的值小于最大值
                    swap(ref list[l], ref list[r]);//交换顺序

            } while (l < r);
            list[low] = list[r];//在最小索引处记录最小值
            list[r] = pivot;//在最大索引处记录最大值
            if (low + 1 < r)//判断最小索引是否小于最大索引
                Sort(list, low, r - 1);//调用自身进行快速排序
            if (r + 1 < high)//判断最大索引是否小于数组长度
                Sort(list, r + 1, high);//调用自身进行快速排序
        }
        catch { }
    }

   
    public int RemoveTheagain01(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            return 0;
        }
        else if (array.Length == 1)
        {
            return 1;
        }
        else
        {
            int i = 0;
            int n = array.Length - 1;
            while (i <= n)
            {
                if (i == n)
                {

                    list.Add(array[i]);
                    i++;
                }
                else
                {
                    int j = i + 1;
                    if (array[i] == array[j])
                    {
                        while (j <= n && array[i] == array[j])
                        {
                            j++;
                        }
                    }

                    list.Add(array[i]);
                    i = j;
                }
            }
            //for (int k = 0; k < list.Count; k++)
            //{
            //    array[k] = list.get(k);
            //}
            return list.Count;
        }
    }

    #region 链表
    List<int> list = new List<int>();
    public LinkedList<int> linkedList = new LinkedList<int>();
    public LinkedListNode<int> p;
    LinkList<int> linkList = new LinkList<int>();
    [ContextMenu("链表输出")]
    public void MyLinkedTest() {
        int[] linkedValue = { 5, 2, 8, 6, 3, 4 };

        for (int i = 0; i < linkedValue.Length; i++)
        {
            linkList.Append(linkedValue[i]);
        }
        linkList.Display();

    }
    #endregion

    #region 查找链表中值
    [ContextMenu("链表中值输出")]
    public void LinkedTest()
    {
        int[] linkedValue = { 5, 2, 8, 6, 3, 4 };
        linkedList.AddLast(default(int));
        for (int i = 0; i < linkedValue.Length; i++)
        {
            Debug.Log(1);
            linkedList.AddLast(new LinkedListNode<int>(linkedValue[i]));
            linkList.Append(linkedValue[i]);
        }

        #region 找中值
        LinkedListNode<int> targetNode;
        int len = -1;
        len = FindMidNode(linkedList, out targetNode);
        if (len == 1)
        {
            Debug.Log("Node1:" + targetNode.Value + " Node2:" + targetNode.Next.Value);
        }
        else if (len == 0)
        {
            Debug.Log("Node1:" + targetNode.Value);
        }
        #endregion
        // Debug.Log(2);
        #region 链表反转
        //  ReverseLinkList(linkList);
        //Debug.Log(5);
        //Node<int> head;
        //head = linkList.Head;
        //int count = 0;
        //while (head != null)
        //{
        //    Debug.Log(6);
        //    count++;
        //    if (count > 100)
        //        break;
        //    Debug.Log(head.Data);
        //    head = head.Next;
        //}
        #endregion

        //Debug.Log(7);
        //Debug.Log("\n" + linkedList.Count + "\n" + linkList.GetLenth());

    }

    /// <summary>
    /// 找到链表的中值
    /// </summary>
    /// <param name="link"></param>
    /// <param name="q"></param>
    /// <returns></returns>
    public int FindMidNode(LinkedList<int> link, out LinkedListNode<int> q) {
        int isevent = 0;
        LinkedListNode<int> p;
        p = link.First;
        q = link.First;
        while (p != null)
        {
            if (p.Next != null)
            {
                p = p.Next.Next;
                q = q.Next;

            }
            else
            {
                p = p.Next;
                isevent = 1;
            }
        }
        return isevent;
    }
    #endregion

    /// <summary>
    /// 链表反转
    /// </summary>
    /// <param name="_l"></param>
    /// <returns></returns>
    /// 
    public void ReverseLinkList(LinkList<int> _l) {
        Node<int> _head, _p, _q;
        _head = _l.Head;
        _q = _head.Next;
        _p = null;
        int count = 0;
        Debug.Log(3);
        //while (count<5)
        //{
        //    Debug.Log(4);
        //    count++;

        //        _head.Data = _q.Data;
        //        _p = _q.Next;
        //        _q.Next = _head;
        //        _head = _q;
        //        _q = _p;

        //}

    }

    #region 删除重复字符
    [ContextMenu("删除重复字符")]
    public void RemoveRepetTest()
    {
        //String s = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        String s = "abbccasdfasd aewfawefasdfawefadfwergW";
        Debug.Log(s);
        // Debug.Log( RemoveDuplucate(s));

        Debug.Log(RemoveDuplucate(s));
    }

    /// <summary>
    /// 删除重复的字符串
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static String RemoveDuplucate(String str)
    {

        char[] chars = str.ToCharArray();
        int len = chars.Length;
        int[] flag = new int[16]; //有8*32=256bit空间，每一bit代表字符是否出现过。
        for (int i = 0; i < len; i++)
        {
            // Debug.Log(chars[i]);
            int index = chars[i] / 16;
            //   Debug.Log("index:    " + index);
            int shift = chars[i] % 16;
            //Debug.Log("shift:    " + shift);
            //Debug.Log("flag[index]:    " + flag[index]);
            //Debug.Log("1 << shift:    " + (1 << shift));
            //Debug.Log("((flag[index] & (1 << shift)) != 0):    " + ((flag[index] & (1 << shift))));
            //Debug.Log(" flag[index] |= (1 << shift):    " +( flag[index] |= (1 << shift)));
            //Debug.Log("\n");
            if ((flag[index] & (1 << shift)) != 0)
            {
                Debug.Log(chars[i]);
                chars[i] = '\0';
            }

            flag[index] |= (1 << shift);
        }

        int j = 0;
        for (int i = 0; i < len; i++)
        {
            if (chars[i] != '\0')
                chars[j++] = chars[i];
        }
        Debug.Log(j);
        return new String(chars, 0, j);

    }
    #endregion

    #region 查找重复字符
    [ContextMenu("字符串")]
    public void FindRepetTest()
    {
        String s = "abbccasdfasd aewfawefasdfawefadfwergW";
        Debug.Log(s);
        Debug.Log(FindRepet(s));
    }

    /// <summary>
    /// 查找重复字符
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public String FindRepet(String str)
    {
        Hashtable ht = new Hashtable();
        Hashtable ht1 = new Hashtable();
        HashSet<char> hashSet = new HashSet<char>();
        HashSet<char> hashSet1 = new HashSet<char>();
        List<int> list = new List<int>();
        int j = 0;
        char[] c = str.ToCharArray();
        for (int i = 0; i < c.Length; i++)
        {
            if (!hashSet.Contains(c[i]))
            {
                //ht.Add(c[i], c[i]);     
                hashSet.Add(c[i]);
                c[j] = c[i];
                j++;
            }
            else
            {
                if (!hashSet1.Contains(c[i]))
                {
                    hashSet1.Add(c[i]);
                    Debug.Log(c[i]);
                }
                //if (!ht1.Contains(c[i]))
                //{
                //    ht1.Add(c[i],c[i]);
                //    Debug.Log(c[i]);
                //}

            }
        }
        return new String(c, 0, j);
    }
    #endregion

    #region 字符串匹配
    [ContextMenu("MyKMP")]
    void MyKMP()
    {
          String mainString = "substring searching algorithm";
        String subString = "searching";
         Debug.Log(KMPSeach(mainString, subString));
    }

    [ContextMenu("Sunday算法")]
    void TestSunday()
    {
        String mainString = "substring searching algorithm";
        String subString = "searching";
        Debug.Log(Sunday(mainString, subString));
    }
    #region 自己的测试KMP算法代码
    /// <summary>
    /// 获得next数组
    /// </summary>
    /// <param name="p"></param>
    /// <param name="next"></param>
    void GetNext(String p, ref int[] next)
    {
        int pLen = p.Length;
        int k = -1;
        int j = 0;
        while (j < pLen - 1)
        {
            // Debug.Log("p[j]:" + p[j]);
            //if (k>=0)
            //{
            //Debug.Log("p[k]:" + p[k]);
            // }
            // Debug.Log("k:" + k + "       j:" + j);
            //p[k]表示前缀，p[j]表示后缀  
            if (k == -1 || p[j] == p[k])
            {
                ++k;
                ++j;
                //   Debug.Log("k:" + k + "      j:" + j);
                if (p[j] != p[k])
                {
                    next[j] = k;
                }
                else
                {
                    next[j] = next[k];
                }


                //   Debug.Log("next[j]:" + next[j]);
            }
            else
            {
                //  Debug.Log("next[k]:" + next[k]+ "   k:" + k );
                k = next[k];
                //  Debug.Log("k = next[k]:" +k);
            }

            // Debug.Log("\n");
        }


    }

    /// <summary>
    /// KMP算法
    /// </summary>
    /// <param name="mainChar"></param>
    /// <param name="subChar"></param>
    /// <returns></returns>
    int KMPSeach(String mainChar, String subChar)
    {
        if (string.IsNullOrEmpty(mainChar) || string.IsNullOrEmpty(subChar))
            return -1;
        var next = new int[subChar.Length];

        int i = 0, j = 0, sLen = subChar.Length, mLen = mainChar.Length;
        for (int u = 0; u < next.Length; u++)
        {
            next[u] = -1;
        }
        GetNext(subChar, ref next);
        while (i < mLen && j < sLen)
        {
            if (j == -1 || mainChar[i] == subChar[j])
            {
                i++;
                j++;
            }
            else
            {
                j = next[j];
            }

        }
        //   Debug.Log(j+"   "+i + "   sLen:" + sLen);
        if (j == sLen)
        {
            return i - j;
        }
        else
            return -1;

    }
    #endregion

    #region 网上的 Sunday和KMP算法
    /// <summary>
    /// Sunday算法
    /// </summary>
    /// <param name="text"></param>
    /// <param name="pattern"></param>
    /// <returns></returns>
    public static int Sunday(string text, string pattern)
    {
        int i, j, m, k;
        i = j = 0;
        int tl, pl;
        int pe;
        int rev = -1;

        if ((null == text || null == pattern) || (tl = text.Length) < (pl = pattern.Length))
            return -1;

        while (i < tl && j < pl)
        {
            if (text[i] == pattern[j])
            {
                //匹配正确，就继续
                ++i;
                ++j;
                continue;
            }

            //匹配失败
            pe = i + pl;
            if (pe >= tl) return -1;

            for (k = pl - 1; k >= 0 && text[pe] != pattern[k]; --k) { }

            i += (pl - k);  //(pl - k) 表示i需要移动的步长
            rev = i;   //记录当前索引
            j = 0;  //重新开始
        }

        return i < tl ? rev : -1;
    }

    /// <summary>
    /// KMP 的获取next数组
    /// </summary>
    /// <param name="subString"></param>
    /// <param name="next"></param>
    static void BuildTable(string subString, ref int[] next)
    {
        if (string.IsNullOrEmpty(subString)) return;

        int j = 0, k = -1;
        next[0] = -1;
        while (j < subString.Length - 1)
        {
            if (-1 == k || subString[j] == subString[k])
            {
                j++;
                k++;
                if (subString[k] != subString[j])
                {
                    next[j] = k;
                }
                else
                {
                    next[j] = next[k];
                }
            }
            else
            {
                k = next[k];
            }
        }
    }

    /// <summary>
    /// KMP查找算法
    /// </summary>
    /// <param name="source">要搜索的字符串</param>
    /// <param name="subString">子串</param>
    /// <returns>子串在source字符串中的开始位置</returns>
    static int KmpSearch(string source, string subString)
    {
        if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(subString))
            return -1;
        var next = new int[subString.Length];
        for (int k = 0; k < next.Length; k++)
        {
            next[k] = -1;
        }
        int i = 0, j = 0, sLen = subString.Length;

        BuildTable(subString, ref next);

        while (i < source.Length)
        {
            if (j == -1 || source[i] == subString[j])
            {
                i++;
                j++;
            }
            else
            {
                j = next[j];
            }
            if (j == sLen)
            {
                Debug.Log("匹配");
                return i - sLen;
            }
        }
        return -1;
    }
    #endregion
    #endregion
    
    #region 递归字符串反转
    [ContextMenu("递归字符串反转")]
    void RecursionReverse()
    {
        String subString = "中文也可以";
        Debug.Log(Reverse(subString));
    }
    /// <summary>
    /// 递归字符串反转
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    static string Reverse(string word)
    {

        if (String.IsNullOrEmpty(word)) return word;

        return Reverse(word.Substring(1)) + word.Substring(0, 1);
    }
    #endregion

    #region 字符是否纯数字
    [ContextMenu("字符是否纯数字")]
    public void FindStringIsNumberTest() {
        String str = "1234asdasd1234";
        Debug.Log(str);
      Debug.Log(  StringIsAllNumber(str));
    }
    bool StringIsAllNumber(String str)
    {
        if (string.IsNullOrEmpty(str))
            return false;
        Char[] chars = str.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] < 48 || chars[i] > 57)
            {
                return false;
            }
        }
     
        return true;
    }
    #endregion

    #region ASCII
    [ContextMenu("输出ASCII码")]
    void TestASCII() {
        for (int i = 1; i <= 255; i++)
        {
            char c = (char)i;//通过强制类型转换来将ASCII码对应的字符数出
          Debug.Log(i + "  " + c);
        }
    }

    [ContextMenu("重复最多的字符(ASCII)")]
    void StringRepetTime()
    {
        String str = "ABCDEFG";
        Debug.Log(str);
        RepetMax(str);

    }

    /// <summary>
    /// 字符串中重复最多的字符
    /// </summary>
    /// <param name="str"></param>
    void RepetMax(string str) {
        int[] asciiTable = new int[256];
        char[] strArray = str.ToCharArray();
        for (int i = 0; i < strArray.Length; i++)
        {
            asciiTable[strArray[i]]++;
        }
        int index = 0;
        int _time = 0;
        for (int i = 0; i < asciiTable.Length; i++)
        {
            if (asciiTable[i]>1)
            {
                if (asciiTable[i]>_time)
                {
                    index = i;
                    _time = asciiTable[i];
                }
               
            }
        }
        if (_time == 0)
        {
            Debug.Log("没有重复的");
        }
        else {
            Debug.Log((char)index + " :" + asciiTable[index]);
        }
     
    }

    #endregion


}

public class Node<T> {
    private T data;
    private Node<T> next;

    public Node(T val,Node<T> p) {
        data = val;
        next = p;
       
    }

    public Node(Node<T> p)
    {
        next = p;
    }
    public Node(T val)
    {
        data = val;
        next = null;
    }
    public Node()
    {
        data = default(T);
        next = null;
    }

    public T Data { get { return data; }
        set { data = value; }
    }

    public Node<T> Next {
        get { return next; }
        set { next = value; }
    }
}

public class LinkList<T> {
    private Node<T> head;
    public Node<T> Head {
        get { return head; }
        set { head = value; }
    }

    public LinkList() {
        head = null;
    }

    public int GetLenth() {
        Node<T> p = head;
        int len = 0;
        while (p!=null)
        {
            len++;
            p = p.Next;
        }
        return len;
    }

    public void Append(T item) {
        Node<T> q = new Node<T>(item);
        Node<T> p = new Node<T>();
        if (head==null)
        {
            head = q;
            return;
        }
        p = head;
        while (p.Next !=null)
        {
            p = p.Next;
        }
        p.Next = q;
    }

    public void Display() {
        Node<T> p = new Node<T>();
        p = this.head;
        while (p!= null)
        {
           Debug.Log(p.Data + "");
            p = p.Next;
        }
    }
}


