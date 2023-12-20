[![build and test](https://github.com/hsjwhh/PDFTools/actions/workflows/build-and-test.yml/badge.svg)](https://github.com/hsjwhh/PDFTools/actions/workflows/build-and-test.yml)
### Winform 编程练习

- 编写一个对 PDF 文件进行操作的小程序
- 引用 iText 操作 PDF，按照说明，需要安装两个包，切记。
```shell
dotnet add package itext --version 8.0.2
dotnet add package itext.bouncy-castle-adapter --version 8.0.2
```
- 程序 UI 使用`ReaLTaiizor`
- 目前实现 pdf 文件合并、分割操作，后续实现 图片合并 pdf 文件