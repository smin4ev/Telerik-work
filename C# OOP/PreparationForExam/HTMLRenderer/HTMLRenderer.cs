using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace HTMLRenderer
{
	public interface IElement
	{
		string Name { get; }
		string TextContent { get; set; }
		IEnumerable<IElement> ChildElements { get; }
		void AddElement(IElement element);
		void Render(StringBuilder output);
		string ToString();
	}

    public class HtmlElement : IElement //0
    {
       private ICollection<IElement> childElements; //6

        public HtmlElement(string name) //15
        {
            this.Name = name;
            this.childElements = new List<IElement>();
            
        }

        public HtmlElement(string name, string textContent):this(name) //4...
        {
            this.TextContent = textContent;
            
        }

        public string Name{get;private set;} //1
        
        public virtual string TextContent{get;set;} //2 //29 virtual
       
        public virtual IEnumerable<IElement> ChildElements //3 //28 virtual
        {
            get { return this.childElements; }
        }

        public virtual void AddElement(IElement element) //5 //27 virtual
        {

            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output) //10 //26 virtual
        {
            if (!string.IsNullOrWhiteSpace(this.Name)) //11
            {
                output.AppendFormat("<{0}>",this.Name);
            }

            if (!string.IsNullOrWhiteSpace(this.TextContent)) //13
            {
                for (int i = 0; i < this.TextContent.Length; i++) //...40
                {
                    char symbol = this.TextContent[i];
                    switch (symbol)
                    { 
                        case '<':
                            output.Append("&lt;");
                                break;
                        case '>':
                                output.Append("&gt;");
                                break;
                        case '&':
                                output.Append("&amp;");
                                break;
                        default:
                            output.Append(symbol);
                            break;
                    }
                }
            }

            foreach (var childElement in this.ChildElements) //14
            {

                output.Append(childElement.ToString());
                
            }


            if (!string.IsNullOrWhiteSpace(this.Name)) //12
            {
                output.AppendFormat("</{0}>", this.Name);
            }
        }

        public override string ToString() //7
        {
            StringBuilder output = new StringBuilder(); //8

            this.Render(output); //9

            return output.ToString();
        }
    } 

    public class HtmlTable : HtmlElement, ITable //16
    {
        private const string TableName = "table"; //25
        private const string TableRowOpenTag = "<tr>";//33
        private const string TableRowCloseTag = "</tr>";//34
        private const string TableCellOpenTag = "<td>";//35
        private const string TableCellCloseTag = "</td>";//36

        private int rows; //17
        private int cols; //18
        private IElement[,] cells; //22

        public HtmlTable(int rows, int cols) //24
            :base(TableName)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.cells = new IElement[this.Rows, this.Cols];
        }
       

        public int Rows //19
        {
            get { return this.rows; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Table rows count must be positive!");
                }
                this.rows = value;
            }
        }

        public int Cols //20
        {
            get { return this.cols; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Table columns count must be positive!");
                }
                this.cols = value;
            }
        }

        public IElement this[int row, int col] //23
        {
            get
            {
               this.ValidateIndecies(row, col);
               return this.cells[row, col];
            }
            set
            {
                this.ValidateIndecies(row, col);

                if (value == null)
                {
                    throw new ArgumentNullException("value", "HTML elements in table cell cannot be null");
                }
                this.cells[row, col] = value;
            }
        }


        public override IEnumerable<IElement> ChildElements //21
        {
            get
            {
                throw new InvalidOperationException("HTML tables do not have child elements!");
            }
        }

        public override string TextContent //31
        {
            get
            {
                throw new InvalidOperationException("Cannot get text content of HTML tables do not have text content!");
            }
            set
            {
                throw new InvalidOperationException("Cannot set text content of HTML tables do not have text content!");
            }
        }

        public override void AddElement(IElement element) //30
        { 
            throw new InvalidOperationException("HTML tables do not have chiled elements so such cannot be added");
        
        }

        public override void Render(StringBuilder output) //32
        {
            output.AppendFormat("<{0}>", this.Name);//37

            for (int row = 0; row < this.Rows; row++)//38
            {
                output.Append(TableRowOpenTag);
                for (int col = 0; col < this.Cols; col++)//39
                {
                    output.Append(TableCellOpenTag);
                    output.Append(this.cells[row, col].ToString());
                    output.Append(TableCellCloseTag);
                }

                output.Append(TableRowCloseTag);
            }

            output.AppendFormat("</{0}>", this.Name);

        }

        private void ValidateIndecies(int row, int col) //21
        {
            if (row < 0 || row >= this.Rows)
            {
                throw new IndexOutOfRangeException("Provided row is out of HTML table dimensions!");
            }
            if (col < 0 || col > this.Cols)
            {
                throw new IndexOutOfRangeException("Provided row is out of HTML table dimensions!");
            }
        }
    }

   


	public interface ITable : IElement
	{
		int Rows { get; }
		int Cols { get; }
		IElement this[int row, int col] { get; set; }
	}

    public interface IElementFactory
    {
		IElement CreateElement(string name);
		IElement CreateElement(string name, string content);
		ITable CreateTable(int rows, int cols);
    }

    public class HTMLElementFactory : IElementFactory //26
    {
		public IElement CreateElement(string name)
		{
            return new HtmlElement(name);
		}

		public IElement CreateElement(string name, string content)
		{
            return new HtmlElement(name, content);
		}

		public ITable CreateTable(int rows, int cols)
		{
            return new HtmlTable(rows, cols);
		}
	}

    public class HTMLRendererCommandExecutor
    {
        static void Main()
        {
			string csharpCode = ReadInputCSharpCode();
			CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using HTMLRenderer;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }
}
