using System.Reflection;
using System.Text;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// Service for managing product images.
/// </summary>
/// <remarks>
/// Offers functions to :
/// <list type="bullet">
/// <item>'Upload' (copy) an image file to the product images directory.</item>
/// <item>Obtain an <see cref="Image"/> instance of a product's image based on the product's Id.</item>
/// </list>
/// </remarks>
internal class ProductImageService {

    private static ProductImageService? instance;

    private ProductImageService() {
    }

    public static ProductImageService GetInstance() {
        return instance ??= new ProductImageService();
    }

    /// <summary>
    /// Uploads a product image to the product images directory.
    /// </summary>
    /// <param name="productId">The Id of the product</param>
    /// <param name="imageOriginalFilePath">The path of the file to upload.</param>
    /// <returns>The <see cref="FileInfo"/> of the uploaded file.</returns>
    /// <exception cref="ArgumentException">If the file to upload does not exist.</exception>
    public FileInfo UploadProductImage(int productId, string imageOriginalFilePath) {
        if (!File.Exists(imageOriginalFilePath)) {
            throw new ArgumentException($"No file exists at the provided image file path [{imageOriginalFilePath}].", nameof(imageOriginalFilePath));
        }
        string targetedFilePath = Path.Combine(
            this.GetProductImagesDirectory().FullName,
            this.ConvertProductIdToImageFileName(
                productId,
                new FileInfo(imageOriginalFilePath).Extension
            )
        );

        File.Copy(imageOriginalFilePath, targetedFilePath, true);
        return new FileInfo(targetedFilePath);
    }

    /// <summary>
    /// Returns the image of the product with the specified ID.
    /// </summary>
    /// <param name="productId">The id of the product to get the image of.</param>
    /// <returns>The image of the specified product as an <see cref="Image"/> instance.</returns>
    /// <exception cref="FileNotFoundException">If the product has no uploaded image file.</exception>
    public Image GetProductImage(int productId) {
        FileInfo? foundFile = this.GetProductImageFile(productId);
        return foundFile == null
            ? throw new FileNotFoundException($"No image file found for product ID [#{productId}].")
            : Image.FromFile(foundFile.FullName);
    }

    private DirectoryInfo GetProductImagesDirectory() {

        // TODO @PROF: review this.

        StringBuilder stringBuilder = new StringBuilder();
        string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location)
            ?? throw new Exception("Failure to get Assembly base path (this should never happen).");
        _ = stringBuilder.Append(exePath);
        _ = stringBuilder.Append(Path.DirectorySeparatorChar);
        _ = stringBuilder.Append("data");
        _ = stringBuilder.Append(Path.DirectorySeparatorChar);
        _ = stringBuilder.Append("images");
        _ = stringBuilder.Append(Path.DirectorySeparatorChar);
        _ = stringBuilder.Append("products");

        DirectoryInfo directoryInfo;
        string prodImagesPath = stringBuilder.ToString();
        directoryInfo = !Directory.Exists(prodImagesPath)
            ? Directory.CreateDirectory(prodImagesPath)
            : new DirectoryInfo(prodImagesPath);
        return directoryInfo;

    }

    private FileInfo? GetProductImageFile(int productId) {
        DirectoryInfo productImagesDirectory = this.GetProductImagesDirectory();
        string targetedFileName = this.ConvertProductIdToImageFileName(productId);
        return productImagesDirectory.EnumerateFiles().FirstOrDefault(
            file => {
                return file.Name.Replace(file.Extension, "") == targetedFileName;
            });
    }

    private string ConvertProductIdToImageFileName(int productId, string? addExtension = null) {
        return productId.ToString().PadLeft(10, '0') + (addExtension ?? "");
    }
}
