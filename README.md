# Wallpaper Manager 🖼️

Wallpaper Manager is a lightweight app that lets you save your favorite wallpapers and apply them easily.

---

## 🆕 Download the latest release

Go to the **Releases** tab and download the version you want.  
- Choose the **.msix** file for the *installer*  
- Or download the **source code** if you prefer manual installation  

> ⚠️ *Do not launch the installer directly from the download page without setting up your environment variable first.*

---

## 🔐 Setup your own Pixabay API key (required for Search)

To use the search feature, you need a Pixabay API key:

1. Create or log in to your Pixabay account here: [pixabay.com](https://pixabay.com/)  
2. Visit the API documentation page: [pixabay.com/api/docs](https://pixabay.com/api/docs/)  
3. Scroll down to the **Parameters** section and copy your *API KEY*  

---

### Set your environment variable

Open a PowerShell window and run the following command (replace `"your-key-here"` with your actual key):

```powershell
[Environment]::SetEnvironmentVariable("PIXABAY_SECRET", "your-key-here", "User")
```

This will save the key to your user environment variables.

---

## 🪛 Configuration

Once your API key is set, Wallpaper Manager is ready to go! You can:

- Import local images and set them as your wallpaper  
- Search and save images from Pixabay directly  
- Customize various settings  

---

If you encounter any issues, please check the **Issues** tab or open a new issue.

## 🎨 UI
#### 🏠 Home
![image](https://github.com/user-attachments/assets/8b1eac11-fd44-49c7-83af-2acd9bd283e4)
---
#### 🔎 Search
![image](https://github.com/user-attachments/assets/4dfee94c-c584-4a89-afdf-f1e49d6266b5)
---
#### ⚙️ Settings
![image](https://github.com/user-attachments/assets/d238affc-1c49-4d31-9b90-f508bb0ce820)


