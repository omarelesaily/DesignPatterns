using StructuralPatterns_Composite.Components;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main()
        {
            // Create leaf objects (Files)
            IComponent file1 = new FileComponent("File1.txt");
            IComponent file2 = new FileComponent("File2.txt");
            IComponent file3 = new FileComponent("File3.docx");

            // Create composite objects (Folders)
            FolderComponent rootFolder = new FolderComponent("Root Folder");
            FolderComponent subFolder1 = new FolderComponent("Sub Folder 1");
            FolderComponent subFolder2 = new FolderComponent("Sub Folder 2");

            // Build the structure
            rootFolder.Add(file1);
            rootFolder.Add(subFolder1);
            subFolder1.Add(file2);
            subFolder1.Add(subFolder2);
            subFolder2.Add(file3);

            // Display the structure
            rootFolder.Display(1);
        }
    }
}
