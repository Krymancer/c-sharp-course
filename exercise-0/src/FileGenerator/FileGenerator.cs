namespace verysmall{
  public abstract class File {
    public abstract void Generate();
  }

  public class Docx : File {
    public override void Generate() {

    }
  }

  public class Xml : File {
    public override void Generate() {

    }
  }

  public class Pdf : File {
    public override void Generate() {

    }
  }

  public class FilesGenerator {
    public void GenerateFiles(IEnumerable<File> Files) {
      foreach(var file in Files) {
        file.Generate();
      }
    }
  }
}
