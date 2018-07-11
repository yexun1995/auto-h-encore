
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_h_encore {
    public static class Language {

        public static Dictionary<string, Dictionary<string, string>> Languages = new Dictionary<string, Dictionary<string, string>> {
            { "English",  new Dictionary<string, string> {
                { "lbl_ChooseLanguage", "Choose Language:" },
                { "lbl_VersionText", "auto h-encore version " },
                { "lbl_Issues", "Issue Tracker" },
                { "lbl_ConnectionMethod", "How do you plan to connect your PS Vita to transfer h-encore?" },
                { "lbl_UnplugVita", "If your Vita is plugged in, unplug it, then click next." },
                { "lbl_InstallingUSB", "Installing USB driver, please wait..." },
                { "lbl_WifiProblems", "If your Vita says you need to update your firmware, turn off Wifi and restart your Vita. This also means you cannot transfer h-encore over Wifi without updating!" },

                { "status_NoFile", "No file selected, will download." },
                { "status_Invalid", "File path is invalid." },
                { "status_Valid", "File selected and hash matches, will import." },
                { "status_BadHash", "File selected but hash does not match, will download." },
                { "status_Override", "File selected but hash does not match. Hash override enabled, will import." },
                { "status_Calculating", "Calculating file hash..." },

                { "txtblock_BeforeRunning", "The application will automatically download QCMA if it is not installed. It will also automatically launch and manage it. That means:\r\n    If QCMA is not installed:\r\n        QCMA will be downloaded for local use by this program.\r\n        A USB driver will be installed if you choose to transfer via USB\r\n    If QCMA is installed:\r\n        Your existing QCMA installation will be used.\r\n        No new USB drivers will be installed, and your configuration will not be overwritten.\r\n\r\nBasically, you no longer need to interact with QCMA unless there are problems. If you have issues, please submit a report on the issue tracker."},
                { "txtblock_Import", "If you've already downloaded some or all of the necessary files, and don't want the application to redownload them, you can select the files here for the program to import." },
                { "txtblock_USBInstructions", "Connect your PS Vita now.\r\n\r\nIf nothing happens:\r\n1. Launch Content Manager on your PS Vita\r\n2. Select Copy Content\r\n3. If prompted: Select PC and USB\r\n\r\nIf it still doesn't work, try restarting your computer and PS Vita and retry (and do the steps above again).\r\n\r\nIf it still doesn't work, you may need to install QCMA manually and pick a driver other than libusbk." },
                { "txtblock_WifiInstructions", "On your PS Vita:\r\n1. Launch Content Manager\r\n2. Select Copy Content\r\n3. Choose PC\r\n4. Choose Wifi\r\n5. Select the name of your PC\r\n6. Enter the code that appears on your PC\r\n7. Select Register\r\n\r\nIf it doesn't work, make sure your Vita and PC are on the same network, or rerun this application and try USB." },

                { "btn_Import", "I've already downloaded some or all of the files and would like to use them rather than redownload them" },
                { "btn_Ok", "OK" },
                { "btn_Close", "Close" },
                { "btn_Start", "Start" },
                { "btn_Done", "Done" },
                { "btn_Browse", "Browse" },
                { "btn_Next", "Next" },
                { "btn_USB", "USB" },
                { "btn_Wifi", "Wi-Fi" },

                { "cbx_Trim", "Trim excess content from bitter smile demo (reduces h-encore app size from ~240MB to ~13MB)" },
                { "cbx_DeleteExisting", "Delete existing files (do this if something went wrong before)" },
                { "cbx_OverrideHashes", "Ignore Mismatch File Hashes" },

                { "browse_Generic", "Browse for " },

                { "info_Finish",  "To finish your h-encore installation:\r\n"
                        + "1. Connect your PS Vita to your PC using Content Manager like you did before (if it isn't still connected)\r\n"
                        + "     If it says you need to update your firmware, turn off Wifi on your Vita and restart the Vita\r\n"
                        + "2. In Content Manager, choose PC -> PS Vita System\r\n"
                        + "3. Select Applications\r\n"
                        + "4. Select PS Vita\r\n"
                        + "5. Select h-encore and hit Copy\r\n"
                        + "6. Run the h-encore app from the Live Area\r\n"
                        + "     If it crashes the first time, try restarting your Vita and launching the bubble again\r\n\r\n"
                        + "Done!"},

                { "warn_HashCompat", "Compatibility is not guranteed when using versions of files this application was not designed for. Continue anyways?" },
                { "warn_DeleteExistingBittersmile", "You must remove the existing bittersmile backup from your QCMA directory. If you want to keep it, move it now. Delete?" },

                { "error_WebException", "Failed to download file. Please check your internet connection." },
                { "error_Unknown", "Something went wrong: {0}" },
                { "error_DirectoryNotFoundException", "A directory that was created seem to have disappeared (did they get deleted?) OR a directory failed to extract earlier OR you are using an unsupported file import." },
                { "error_UnauthorizedAccessException", "The application doesn't have write access to the directory it was installed in. Try rerunning the application as administrator." },
                { "error_FileNotFoundException",  "A file that was created seem to have disappeared (did they get deleted?) OR a file failed to extract earlier OR you are using an unsupported file import."},
                { "error_InvalidOperationException",  "A download is corrupt. Make sure your network is stable."},
                { "error_TargetInvocationException", "Failed to create MD5 calculator." },
                { "error_Template", "Error {0} occurred.\r\n\r\n{1}\r\n\r\nPlease retry the process. If you can't solve the issue, please create an issue on the issue tracker with this error code." },
                { "error_Redownload",  "Error 1001-0105\r\n\r\nFailed to download file {0}\r\n\r\nMake sure your internet is connected and/or retry. If it still doesn't work, create an issue on the Github issue tracker."},

                { "log_SearchingForQCMA", "Searching for QCMA..." },
                { "log_FoundQCMA", "Found QCMA." },
                { "log_QCMANotFound", "QCMA not found, will download." },
                { "log_KillingQCMA", "Killing any running QCMA processes..." },
                { "log_QCMARegistry", "Importing QCMA registry information..." },
                { "log_ScrubAID", "Scrubbing AID value" },
                { "log_Prompt", "Prompting user for information..." },
                { "log_Done", "        Done!" },
                { "log_WipeFiles", "Deleting old files..." },
                { "log_Import", "File import for file {0} valid." },
                { "log_DownloadValid", "File {0} already downloaded and valid, won't redownload." },
                { "log_DownloadInvalid", "File {0} already downloaded but hash doesn't match, will redownload." },
                { "log_NotDownloaded", "File {0} not downloaded or imported, will download." },
                { "log_WorkingDirs", "Generating working directories..." },
                { "log_CorrectLocation", "File {0} in correct location, skipping." },
                { "log_Importing", "Importing {0}" },
                { "log_Downloading", "Downloading {0}" },
                { "log_Extracting", "Extracting {0}" },
                { "log_ExtractingPKG", "Extracting bittersmile demo with pkg2zip..." },
                { "log_Trimming", "Trimming excess content from bittersmile demo..." },
                { "log_MoveToHencore", "Moving {0} to h-encore working directory..." },
                { "log_MoveLicense", "Moving license file..." },
                { "log_GetCMA", "Getting CMA encryption key using AID {0}" },
                { "log_GotCMA", "Got CMA encryption key {0}" },
                { "log_Packaging", "Packaging h-encore {0} using psvimgtools..." },
                { "log_MoveToQCMA", "Moving h-encore files to QCMA APP directory...\r\n" },
                { "log_Finished", "auto h-encore Finished!!\r\n" },

                { "title_Main", "auto h-encore" },
                { "title_Import", "Import Existing Files" },
                { "title_Warning", "Warning" },
                { "title_Error", "Error" }
            } },
            { "简体中文",  new Dictionary<string, string> {
                { "lbl_ChooseLanguage", "选择语言:" },
                { "lbl_VersionText", "自动 h-encore 版本 " },
                { "lbl_Issues", "问题追踪器" },
                { "lbl_ConnectionMethod", "您打算如何连接 PS Vita 以传送 h-encore?" },
                { "lbl_UnplugVita", "如果您的 Vita 已经连接, 请拔掉它, 然后点击 下一步." },
                { "lbl_InstallingUSB", "正在安装 USB 驱动, 请稍候..." },
                { "lbl_WifiProblems", "如果您的 Vita 报告需要更新系统, 关闭 Wifi 并重启 Vita. 这也意味着您在未更新系统前无法通过 Wifi 传送 h-encore!" },


                { "status_NoFile", "未选择任何文件, 将开始下载." },
                { "status_Invalid", "文件目录无效." },
                { "status_Valid", "已选择文件且校验通过, 即将导入." },
                { "status_BadHash", "已选择文件但校验未通过, 将开始下载." },
                { "status_Override", "已选择文件且校验未通过. 已忽略不匹配校验信息, 即将导入." },
                { "status_Calculating", "校验中..." },

                { "txtblock_BeforeRunning", "如果未安装 QCMA, 本程序将自动下载. 本程序也将自动启动和管理 QCMA 程序. 这意味着:\r\n    如果 QCMA 尚未安装:\r\n        本程序将下载 QCMA 供本地使用.\r\n        如果您选择通过 USB 传输, 将安装 USB驱动程序.\r\n    如果 QCMA 已安装:\r\n        将使用您现有的 QCMA 程序.\r\n        不会安装新的 USB 驱动程序, 也不会覆盖您的配置.\r\n\r\n基本上, 除非出现问题, 否则您不需要与 QCMA 交互. 如果您遇到问题, 请在问题追踪器提交报告. "},
                { "txtblock_Import", "如果您已经下载了部分或全部必要文件, 并且不希望本程序重新下载它们, 则可以在此处选择要导入程序的文件." },
                { "txtblock_USBInstructions", "立即连接您的 PS Vita.\r\n\r\n如果没有反应:\r\n1. 启动 PS Vita 上的内容管理程序\r\n2. 选择 复制内容\r\n3. 如果提示: 选择 PC 和 USB\r\n\r\n如果依旧不工作, 尝试重启电脑和 Vita 并重试 (以及重做上述过程).\r\n\r\n如果依旧不工作, 您或许需要手动安装 QCMA 并选择安装 libusbk 以外的驱动程序." },
                { "txtblock_WifiInstructions", "在您的 PS Vita 端:\r\n1. 启动 内容管理 程序\r\n2. 选择 复制内容\r\n3. 选择 电脑\r\n4. 选择 Wi-Fi\r\n5. 选择您的 PC 的名称\r\n6. 输入 PC 上显示的代码\r\n7. 选择 添加 继续\r\n\r\n如果它不工作，请确保您的 Vita 和 PC 在同一网络上，或重新运行此应用程序并尝试 USB 连接。" },


                { "btn_Import", "我已经下载了一部分或者全部必要的文件, 我想使用它们, 不要重新下载" },
                { "btn_Ok", "确定" },
                { "btn_Close", "关闭" },
                { "btn_Start", "启动" },
                { "btn_Done", "完成" },
                { "btn_Browse", "浏览" },
                { "btn_Next", "下一步" },
                { "btn_USB", "USB" },
                { "btn_Wifi", "Wi-Fi" },


                { "cbx_Trim", "删减 bitter smile demo 的多余内容 (将 h-encore app 大小 从 240MB 减小到 13MB)" },
                { "cbx_DeleteExisting", "删除已存在的文件 (如果之前的操作出错，请勾选它)" },
                { "cbx_OverrideHashes", "忽略不匹配的文件校验信息" },

                { "browse_QCMA", "请选择您的 PS Vita/APP 目录 (可以在 QCMA 设置界面找到)" },
                { "browse_Generic", "浏览 " },

                { "info_Finish",  "完成 h-encore 安装:\r\n"
                        + "1. 像之前的操作那样, 使用 内容管理 程序将 PS Vita 连接到 PC（如果它仍未连接）\r\n"
                        + "     如果Vita提示您需要更新系统, 关闭无线网络后重启 Vita\r\n"
                        + "2. 在 内容管理 程序界面, 选择 电脑 -> PS Vita\r\n"
                        + "3. 选择 应用程序\r\n"
                        + "4. 选择 PS Vita\r\n"
                        + "5. 选择 h-encore 并点击 复制\r\n"
                        + "6. 启动主界面的 h-encore 程序\r\n"
                        + "     如果初次启动崩溃, 尝试重启Vita后再运行该气泡\r\n\r\n"
                        + "完成!"},

                { "warn_HashCompat", "使用不匹配的文件版本无法保证兼容性. 您确定要继续么?" },
                { "warn_DeleteExistingBittersmile", "您必须移除 QCMA 备份目录内已存在的 bittersmile 备份. 如果您想保留它,请立刻手动转移. 是否删除?" },

                { "error_WebException", "下载文件失败. 请检查网络连接." },
                { "error_Unknown", "出现错误: {0}" },
                { "error_DirectoryNotFoundException", "创建的目录丢失 (被删除了?) 或者上一步的目录未能提取, 或者您正在导入不受支持的文件." },
                { "error_UnauthorizedAccessException", "本程序没有对其安装目录的写入权限. 请尝试以管理员身份重新运行本程序." },
                { "error_FileNotFoundException",  "创建的文件丢失 (被删除了?) 或者上一步文件提取失败,或者您正在导入不受支持的文件."},
                { "error_InvalidOperationException",  "下载内容已损坏. 确保您的网络稳定."},
                { "error_TargetInvocationException", "MD5 校验失败." },
                { "error_Template", "发生 {0} 错误.\r\n\r\n{1}\r\n\r\n请重试该操作. 如果您无法解决问题, 请使用此错误代码在问题追踪器上创建报告." },
                { "error_Redownload",  "错误 1001-0105\r\n\r\n下载 {0} 文件失败\r\n\r\n确保您已联网并重试. 如果软件仍然不起作用，请在Github问题追踪器上创建一个报告."},

                { "log_SearchingForQCMA", "正在搜索 QCMA..." },
                { "log_FoundQCMA", "已找到 QCMA." },
                { "log_QCMANotFound", "未找到 QCMA, 将开始下载." },
                { "log_KillingQCMA", "结束正在运行的 QCMA 进程..." },
                { "log_QCMARegistry", "正在导入 QCMA 注册表信息..." },
                { "log_ScrubAID", "清除 AID 值" },
                { "log_Prompt", "提醒用户提供信息..." },

                { "log_Done", "        完成!" },
                { "log_WipeFiles", "删除旧文件..." },
                { "log_Import", "导入的文件 {0} 有效." },
                { "log_DownloadValid", "文件 {0} 已下载并且有效, 不再重新下载." },
                { "log_DownloadInvalid", "文件 {0} 已下载但 hash 不匹配, 将要重新下载." },
                { "log_NotDownloaded", "文件 {0} 未下载或者导入, 将开始下载." },
                { "log_WorkingDirs", "生成工作目录..." },
                { "log_CorrectLocation", "文件 {0} 在正确的位置, 跳过." },
                { "log_Importing", "正在导入 {0}" },
                { "log_Downloading", "正在下载 {0}" },
                { "log_Extracting", "正在解压 {0}" },
                { "log_ExtractingPKG", "正在用 pkg2zip 解包 bittersmile demo..." },
                { "log_Trimming", "正在删减 bitter smile demo 的多余内容..." },
                { "log_MoveToHencore", "正在移动 {0} 到 h-encore 的工作目录..." },
                { "log_MoveLicense", "正在移动许可文件..." },
                { "log_GetCMA", "正在利用 AID 获取 CMA 加密密钥 {0}" },
                { "log_GotCMA", "已得到 CMA 加密密钥 {0}" },
                { "log_Packaging", "正在利用 psvimgtools {0} 打包 h-encore..." },
                { "log_MoveToQCMA", "正在移动 h-encore 文件到 QCMA APP 备份目录...\r\n" },
                { "log_Finished", "自动 h-encore 完成!!\r\n" },

                { "title_Main", "自动 h-encore" },
                { "title_Import", "导入已下载的文件" },
                { "title_Warning", "警告" },
                { "title_Error", "错误" }
            } },
            { "Español-ES",  new Dictionary<string, string> {
                { "lbl_ChooseLanguage", "Elegir idioma:" },
                { "lbl_VersionText", "Versión de auto H-encore " },
                { "lbl_Issues", "Seguimiento de incidencias" },
                        { "lbl_ConnectionMethod", "¿Cómo vas a conectar tu PS Vita para transferir H-encore?" },
                { "lbl_UnplugVita", "Si tu PS Vita está conectada, desconéctala y pulsa siguiente." },
                { "lbl_InstallingUSB", "Instalando driver del USB, por favor, espera..." },
                { "lbl_WifiProblems", "Si tu PS Vita te pone que necesita actualizar tu firmware, apaga el Wifi y reinicia tu PS Vita. ¡Esto también significa que no puedes transferir H-encore por Wifi si no actualizas!" },

                { "status_NoFile", "Ningún archivo seleccionado, se descargará el archivo." },
                { "status_Invalid", "Ruta no válida." },
                { "status_Valid", "El archivo y el hash seleccionado son correctos, se importarán." },
                { "status_BadHash", "El hash no concuerda con el archivo, se descargará." },
                { "status_Override", "El hash no concuerda con el archivo, habilitado deshabilitar hash, se importará." },
                { "status_Calculating", "Calculando archivo hash..." },

                { "txtblock_BeforeRunning", "QCMA se descargará automáticamente si no está instalado. También lo ejecutará y lo administrará. Eso significa que:\r\n    Si QCMA no está instalado:\r\n        QCMA se descargará para el uso local de este programa.\r\n        Un driver USB se instalará si eliges transferir por USB.\r\n    Si QCMA está instalado:\r\n        Se usará la instalación de QCMA que tengas.\r\n        Ningún driver USB se instalará, y tu configuración no se sobrescribirá.\r\n\r\nBásicamente, no tienes que interactuar con QCMA a no ser que surja algún problema. Si tienes alguna incidencia, por favor envía un informe en el seguimiento de incidencias."},
                { "txtblock_Import", "Si has descargado todos o algunos de los archivos, y no quieres que la aplicación los vuelva a descargar, aquí puedes seleccionar los archivos para que el programa los importe." },
                { "txtblock_USBInstructions", "Ahora, conecta tu PS Vita.\r\n\r\nSi nada sucede:\r\n1. Usa el Gestor de Contenido en tu PS Vita\r\n2. Selecciona Copiar Contenido\r\n3. Si te da a elegir: Selecciona PC y USB\r\n\r\nSi sigue sin funcionar, intenta reiniciando tu PC y tu PS Vita y reinténtalo (y haz los pasos de antes otra vez).\r\n\r\nSi sigue sin funcionar, puede que tengas que instalar QCMA manualmente y elegir un driver que no sea libusbk." },
                { "txtblock_WifiInstructions", "En tu PS Vita:\r\n1. Usa el Gestor de Contenido\r\n2. Selecciona Copiar Contenido\r\n3. Elige PC\r\n4. Elige Wifi\r\n5. Selecciona el nombre de tu PC\r\n6. Introduce el código que aparece en tu PC\r\n7. Selecciona Registrar\r\n\r\nSi no funciona, asegúrata que tu PS Vita y tu PC están en la misma red, o reinicia esta aplicación e inténtalo por USB." },

                { "btn_Import", "Ya se descargaron todos o parte de los archivos y puedes usarlos o volverlos a descargar." },
                { "btn_Ok", "OK" },
                { "btn_Close", "Cerrar" },
                { "btn_Start", "Empezar" },
                { "btn_Done", "Hecho" },
                { "btn_Browse", "Navegar" },
                        { "btn_Next", "Siguiente" },
                { "btn_USB", "USB" },
                { "btn_Wifi", "Wi-Fi" },

                { "cbx_Trim", "Eliminar contenido sobrante de la demo bitter smile (reduce el tamaño de app de H-encore de ~240MB a ~13MB)." },
                { "cbx_DeleteExisting", "Borrar archivos existentes (haz esto si ha ocurrido algún error en el proceso)." },
                { "cbx_OverrideHashes", "Ignorar los Hashes de los archivos." },

                { "browse_QCMA", "Localiza tu directorio PS Vita de QCMA (lo encontrarás en las opciones de QCMA bajo Aplicación / Copias de Seguridad)." },
                { "browse_Generic", "Buscar " },

                { "info_Finish",  "Para finalizar la instalación de H-encore:\r\n"
                        + "1. Conecta tu PS Vita a tu PC usando Gestor de Contenido como antes (si no sigue conectada).\r\n"
                        + "     (Si pone que tienes que actualizar el firmware, apaga el wifi en tu PS Vita y reiniciala.)\r\n"
                        + "4. En Gestor Contenido, elige PC -> PS Vita.\r\n"
                        + "5. Selecciona Aplicaciones.\r\n"
                        + "6. Selecciona PS Vita.\r\n"
                        + "7. Selecciona H-encore y pulsa en Copiar.\r\n"
                        + "8. Ejecuta la aplicación H-encore desde el Live Area.\r\n"
                        + "     Si no funciona la primera vez, reiniciar tu PS Vita y ejecútalo de nuevo.\r\n\r\n"
                        + "¡Acabado!"},

                { "warn_HashCompat", "La compatibilidad no está garantizada usando versiones de los archivos no diseñados para esta aplicación. ¿Continuar de todas formas?" },
                { "warn_DeleteExistingBittersmile", "Debes borrar la copia de seguridad de bitter smile en el directorio de QCMA. Si no quieres borrarlo, muévelo a otro directorio. ¿Borrar?" },

                { "error_WebException", "Fallo al descargar el archivo. Por favor, comprueba tu conexión a internet." },
                { "error_Unknown", "Algo ha fallado: {0}." },
                { "error_DirectoryNotFoundException", "Un directorio creado ha desaparecido (¿Ha sido borrado?) O un directorio falló al extraerse O estás importando un fichero no soportado." },
                { "error_UnauthorizedAccessException", "La aplicación no tiene permiso de escritura en el directorio en el que está instalado. Intenta ejecutar la aplicación como Administrador." },
                { "error_FileNotFoundException",  "Un archivo creado ha desaparecido (¿Ha sido borrado?) O un archivo falló al extraerse O estás importando un fichero no soportado."},
                { "error_InvalidOperationException",  "Hay una descarga corrupta. Asegúrate que tu conexión de red es estable."},
                { "error_TargetInvocationException", "Fallo al crear calculadora de MD5." },
                { "error_Template", "Error {0}.\r\n\r\n{1}\r\n\r\nPor favor intenta de nuevo el proceso. Si no puedes solucionar esta incidencia, por favor crea una incidencia en el seguimiento de incidencias." },
                { "error_Redownload",  "Error 1001-0105\r\n\r\nFallo al descargar el archivo {0}\r\n\r\nAsegúrate que tienes conexión a internet y/o inténtalo de nuevo. Si sigue sin funcionar, crea una incidencia en el seguimiento de incidencias de Github."},

                { "log_SearchingForQCMA", "Buscando QCMA..." },
                { "log_FoundQCMA", "Encontrado QCMA." },
                { "log_QCMANotFound", "QCMA no encontrado, se descargará." },
                { "log_KillingQCMA", "Eliminando procesos corriendo QCMA..." },
                { "log_QCMARegistry", "Importando información de registro de QCMA..." },
                { "log_ScrubAID", "Depurando valor de AID." },
                { "log_Prompt", "Preguntando información del usuario..." },
                { "log_Done", "        ¡Hecho!" },
                { "log_WipeFiles", "Borrando archivos antigüos..." },
                { "log_Import", "Importar archivo {0} válido." },
                { "log_DownloadValid", "El archivo {0} ya ha sido descargado y validado, no se descargará." },
                { "log_DownloadInvalid", "El archivo {0} ya ha sido descargado pero el hash no concuerda, se volverá a descargar." },
                { "log_NotDownloaded", "El archivo {0} no se ha descargado o importado, se descargará." },
                { "log_WorkingDirs", "Generando directorios válidos..." },
                { "log_CorrectLocation", "El archivo {0} está en la localización correcta, se omitirá." },
                { "log_Importing", "Importando {0}." },
                { "log_Downloading", "Descargando {0}." },
                { "log_Extracting", "Extrayendo {0}." },
                { "log_ExtractingPKG", "Extrayendo demo de bitter smile con pkg2zip..." },
                { "log_Trimming", "Eliminando exceso de datos de la demo de bitter smile..." },
                { "log_MoveToHencore", "Moviendo {0} a directorio válido de H-encore..." },
                { "log_MoveLicense", "Moviendo archivo de licencia..." },
                { "log_GetCMA", "Consiguiendo clave de encripción CMA usando AID {0}..." },
                { "log_GotCMA", "Consiguiendo clave de encripción CMA {0}..." },
                { "log_Packaging", "Empaquetando H-encore {0} usando psvimgtools..." },
                { "log_MoveToQCMA", "Moviendo archivos de H-encore al directorio APP de QCMA...\r\n" },
                { "log_Finished", "¡¡Auto H-encore finalizado!!\r\n" },

                {"title_Main", "auto H-encore" },
                {"title_Import", "Importar archivos"},
                {"title_Warning", "Advertencia"},
                {"tittle_Error", "Error"},
            } },
            { "Italiano",  new Dictionary<string, string> {
               { "lbl_ChooseLanguage", "Scegli la lingua:" },
                { "lbl_VersionText", "versione auto h-encore " },
                { "lbl_Issues", "Tracker dei problemi" },
                        { "lbl_ConnectionMethod", "In che modo vuoi connettere la tua PS Vita  per il trasferimento di h-encore?" },
                { "lbl_UnplugVita", "Se la tua PSVita è collegata, scollegala, quindi fai clic su Avanti." },
                { "lbl_InstallingUSB", "Installazione del driver USB, attendere prego..." },
                { "lbl_WifiProblems", "Se la tua PSVita dice che devi aggiornare il tuo firmware, spegni la Wifi e riavvia la PSVita. Questo significa anche che non è possibile trasferire h-encore su Wifi senza aggiornamento!" },

                { "status_NoFile", "Nessun file selezionato, verrà scaricato." },
                { "status_Invalid", "Il percorso del file non è valido." },
                { "status_Valid", "Il file selezionato e le corrispondenze hash verranno importate." },
                { "status_BadHash", "Il file selezionato, ma l'hash non corrisponde, verrà scaricato." },
                { "status_Override", "File selezionato ma l'hash non corrisponde. Hash override abilitato, verrà importato." },
                { "status_Calculating", "Calcolo dell'hash del file..." },

                { "txtblock_BeforeRunning", "L'applicazione scaricherà automaticamente il QCMA se non è installato. Inoltre lo avvierà e lo gestirà automaticamente. Questo significa:\r\n    Se QCMA non è installato:\r\n        QCMA verrà scaricato per uso locale da questo programma.\r\n        Se si sceglie di trasferire tramite USB, verrà installato un driver USB\r\n    Se QCMA è installato:\r\n        Verrà utilizzata l'installazione del QCMA esistente.\r\n        Non verranno installati nuovi driver USB e la configurazione non verrà sovrascritta.\r\n\r\nFondamentalmente, non è più necessario interagire con QCMA, a meno che non ci sono problemi. Se avete problemi, invia una segnalazione su tracker dei problemi."},
                { "txtblock_Import", "Se hai già scaricato alcuni o tutti i file necessari, e non vuoi che l'applicazione li scarichi di nuovo, qui puoi selezionare i file da importare per il programma." },
                { "txtblock_USBInstructions", "Collegare ora la PS Vita.\r\n\r\nSe non accade nulla:\r\n1. Avviare Gestione Contenuto su PS Vita\r\n2. Selezionare copia contenuto\r\n3. Se richiesto: selezionare PC e USB\r\n\r\nSe ancora non funziona, provare a riavviare il computer e PS Vita e riprova (e ripetere i passaggi precedenti).\r\n\r\nSe ancora non funziona, potrebbe essere necessario installare manualmente QCMA e scegliere un driver diverso da libusbk." },
                { "txtblock_WifiInstructions", "Su PS Vita:\r\n1. Avviare Gestione Contenuto\r\n2.Seleziona Copia contenuto\r\n3. Scegli PC\r\n4. Scegli Wifi\r\n5.Selezionare il nome del vostro PC\r\n6. Inserisci il codice che appare sul tuo PC\r\n\r\nSe non funziona, assicurarsi che la PSVita e il PC siano sulla stessa rete, o eseguire nuovamente questa applicazione e riprovare la USB." },

                { "btn_Import", "Ho già scaricato alcuni o tutti i file e vorrei utilizzarli invece di riscaricarli" },
                { "btn_Ok", "OK" },
                { "btn_Close", "Chiudi" },
                { "btn_Start", "Start" },
                { "btn_Done", "Fatto" },
                { "btn_Browse", "Sfoglia" },

                        { "btn_Next", "Avanti" },
                { "btn_USB", "USB" },
                { "btn_Wifi", "Wi-Fi" },


                { "cbx_Trim", "Ritaglia il contenuto in eccesso dalla demo bitter smile (riduce le dimensioni delle app h-encore da ~ 240 MB a ~ 13 MB)" },
                { "cbx_DeleteExisting", "Elimina i file esistenti (fai questo se qualcosa è andato storto prima)" },
                { "cbx_OverrideHashes", "Ignora hash di file non corrispondenti" },

                { "browse_QCMA", "Individua la cartella QCMA PS Vita (trovala nelle impostazioni QCMA in Applicazioni / Backup)" },
                { "browse_Generic", "Sfoglia per " },

                { "info_Finish",  "Per finire l'installazione di h-encore:\r\n"
                         + "1. Collegare la tua PS Vita al PC tramite Gestione Contenuto come hai fatto prima (se non è ancora collegato)\r\n"
                         + "     Se dice che è necessario aggiornare il firmware, disattivare la Wifi su PSVita e riavviare la PSVita\r\n"
                         + "4. In Gestione Contenuto, scegli PC -> Sistema PS Vita\r\n"
                         + "5. Seleziona Applicazioni\r\n"
                         + "6. Seleziona PS Vita\r\n"
                         + "7. Seleziona h-encore e premere su Copia\r\n"
                         + "8. Eseguire l'applicazione di h-encore dal Live Area\r\n"
                         + "     Se si blocca per la prima volta, prova a riavviare la PSVita e a lanciare nuovamente la bolla\r\n\r\n"
                         + "Fatto!"},

                { "warn_HashCompat", "La compatibilità non è garantita quando si utilizzano versioni di file per cui questa applicazione non è stata progettata. Continuare comunque?" },
                { "warn_DeleteExistingBittersmile", "È necessario rimuovere il backup bittersmile esistente dalla directory QCMA. Se vuoi tenerlo, spostalo ora. Elimina?" },

                { "error_WebException", "Impossibile scaricare il file. Per favore controlla la tua connessione Internet." },
                { "error_Unknown", "Qualcosa è andato storto: {0}" },
                { "error_DirectoryNotFoundException", "Una cartella che è stata creata sembra essere scomparsa (è stata eliminata?) OPPURE una cartella non è stata in grado di estrarre prima O si sta utilizzando un'importazione di file non supportata." },
                { "error_UnauthorizedAccessException", "L'applicazione non ha accesso in scrittura nella cartella in cui è stata installata. Prova a rieseguire l'applicazione come amministratore." },
                { "error_FileNotFoundException",  "Un file che è stato creato sembra essere scomparso (sono stati cancellati?) OPPURE un file non è stato in grado di estrarre prima O si sta utilizzando un'importazione di file non supportata."},
                { "error_InvalidOperationException",  "Un download è corrotto. Assicurati che la tua rete sia stabile."},
                { "error_TargetInvocationException", "Impossibile creare il calcolatore MD5." },
                { "error_Template", "Errore {0} riscontrato.\r\n\r\n{1}\r\n\r\nSi prega di riprovare il processo. Se non riesci a risolvere il problema, crea un problema sul tracker dei problemi con questo codice di errore." },
                { "error_Redownload",  "Errore 1001-0105\r\n\r\nImpossibile scaricare il file {0}\r\n\r\nAssicurati che la tua connessione a Internet sia connessa e / o riprova. Se continua a non funzionare, crea un problema sul tracker dei problemi di Github."},

                { "log_SearchingForQCMA", "Ricerca del QCMA in corso..." },
                { "log_FoundQCMA", "Il QCMA è stato trovato." },
                { "log_QCMANotFound", "QCMA non trovato, deve essere scaricato." },
                { "log_KillingQCMA", "Chiusura di tutti i processi QCMA in esecuzione..." },
                { "log_QCMARegistry", "Importazione delle informazioni del registro QCMA..." },
                { "log_ScrubAID", "Scrubbing AID value" },
                { "log_Prompt", "Richiesta delle informazioni utente in corso..." },

                { "log_Done", "        Fatto!" },
                { "log_WipeFiles", "Eliminazione dei vecchi file..." },
                { "log_Import", "Importazione dei file per il file {0} valido." },
                { "log_DownloadValid", "File {0} già scaricato e valido, non verrà riscaricato." },
                { "log_DownloadInvalid", "File {0} già scaricato ma l'hash non corrisponde, verrà riscaricato." },
                { "log_NotDownloaded", "File {0} non scaricato o importato, verrà scaricato." },
                { "log_WorkingDirs", "Generazione delle cartelle di lavoro..." },
                { "log_CorrectLocation", "File {0} nella posizione corretta, saltando." },
                { "log_Importing", "Importazione di {0}" },
                { "log_Downloading", "Scaricamento di {0}" },
                { "log_Extracting", "Estrazione di {0}" },
                { "log_ExtractingPKG", "Estrazione della demo di bittersmile con pkg2zip..." },
                { "log_Trimming", "Ritaglio dei contenuti in eccesso dalla demo di bittersmile..." },
                { "log_MoveToHencore", "Spostamento di {0} nella cartella di lavoro di h-encore..." },
                { "log_MoveLicense", "Spostamento del file di licenza..." },
                { "log_GetCMA", "Ottenimento della chiave di crittografia CMA utilizzando l'AID{0}" },
                { "log_GotCMA", "Ho la chiave di crittografia CMA {0}" },
                { "log_Packaging", "Rimpacchettamento di h-encore {0} utilizzando psvimgtools..." },
                { "log_MoveToQCMA", "Spostamento dei file h-encore nella cartella APP del QCMA...\r\n" },
                { "log_Finished", "Processo finito.auto h-encore creato con successo!!\r\n" },

                { "title_Main", "auto h-encore" },
                { "title_Import", "Importa file esistenti" },
                { "title_Warning", "Attenzione" },
                { "title_Error", "Errore" }
            } },
            { "Русский",  new Dictionary<string, string> {
                { "lbl_ChooseLanguage", "Выберите язык:" },
                { "lbl_VersionText", "Версия auto h-encore " },
                { "lbl_Issues", "Issue-трекер" },

                        { "lbl_ConnectionMethod", "Как вы хотите подключать PS Vita для переноса h-encore?" },
                { "lbl_UnplugVita", "Если ваша Vita подключена, то отключите её и нажмите Далее." },
                { "lbl_InstallingUSB", "Установка USB драйвера, пожалуйста подождите..." },
                { "lbl_WifiProblems", "Если ваша Vita требует обновить прошивку, то выключите Wi-Fi и перезагрузите её. Также это означает, что вы не сможете перенести h-encore через Wi-Fi без обновления!" },

                { "status_NoFile", "Файл не выбран и он будет загружен." },
                { "status_Invalid", "Неверный путь к файлу." },
                { "status_Valid", "Файл выбран и проверка хэша прошла успешно." },
                { "status_BadHash", "Файл выбран, но хэш не прошел проверку, он будет переустановлен." },
                { "status_Override", "Файл выбран, но хэш не прошел проверку. Перерасчет хэша запущен и он будет импортирован." },
                { "status_Calculating", "Расчет хэша файла..." },


                { "txtblock_BeforeRunning", "Программа автоматически установит QCMA, если вы не сделали этого сами. Она также сама запустит и настроит его. Это значит:\r\n    Если QCMA не установлен:\r\n        QCMA будет настроен и использован исключительно для использования с auto h-encore.\r\n        USB драйвер будет установлен, если вы выбрали перенос через USB.\r\n    Если QCMA уже установлен:\r\n        Будет использован существующий QCMA.\r\n        Новых USB драйверов не будет установлено и ваши настройки не будут изменены. \r\n\r\nВ принципе, вам больше не потребуется взаимодействовать с QCMA до тех пор, пока не возникнут проблемы. Если проблемы все-таки возникнут, то сообщите об этом в issue-трекере."},
                { "txtblock_Import", "Если вы заранее установили все нужные файлы и не хотите чтоб программа снова их установила, то здесь вы можете выбрать уже имеющиеся файлы." },
                { "txtblock_USBInstructions", "Подключите вашу PS Vita.\r\n\r\nЕсли ничего не происходит:\r\n1. Запустите Управление даннными на вашей PS Vita\r\n2. Выберите Скопировать данные\r\n3. Если все прошло успешно: выберите Компьютер и Кабель USB\r\n\r\nЕсли все равно ничего не работает, попробуйте перезапустить компьютер и PS Vita,и попробуйте заново (и все шаги с самого начала).\r\n\r\nЕсли не работает даже так, вам нужно установить QCMA самостоятельно, и установить любой драйвер кроме libusbk." },
                { "txtblock_WifiInstructions", "На вашей PS Vita:\r\n1. Запустите Управление даннными\r\n2. Выберите Скопировать данные\r\n3. Выберите Компьютер\r\n4. Выберите Wi-Fi\r\n5. Выберите ваш компьютер\r\n6. Напишите появившийся код на компьютере \r\n7.Нажмите Зарегестрировать\r\n\r\nЕсли это не сработало, убедитесь что Vita и компьютер находятся в одной локальной сети, или перезапустите auto h-encore и попробуйте USB режим." },

                { "btn_Import", "Я уже загрузил некоторые или все файлы и хотел бы использовать их, а не загружать их заново." },
                { "btn_Ok", "OK" },
                { "btn_Close", "Закрыть" },
                { "btn_Start", "Начать" },
                { "btn_Done", "Готово" },
                { "btn_Browse", "Обзор" },
                { "btn_Next", "Далее" },
                { "btn_USB", "USB" },
                { "btn_Wifi", "Wi-Fi" },


                { "cbx_Trim", "Обрезать лишний контент из bittersmile demo (размер h-encore уменьшается с ~240MБ до ~13MБ)" },
                { "cbx_DeleteExisting", "Удаление лишних файлов (сделайте это, если ранее что-то пошло не так)" },
                { "cbx_OverrideHashes", "Игнорировать несоответствие хэша" },

                { "browse_QCMA", "Откройте директорию QCMA PS Vita (найдите её в настройках QCMA (Applications / Backups)" },
                { "browse_Generic", "Обзор " },

                { "info_Finish",  "Чтобы закончить установку h-encore:\r\n"
                        + "1. Подключите PS Vita к PC используя Управление данными, если она еще не подключена (так же, как вы делали ранее)\r\n"
                        + "     Если требуется обновить прошивку, то выключите Wi-Fi на Vita и перезагрузите её\r\n"
                        + "2. В Управлении данными нажмите Компьютер -> Система PS Vita\r\n"
                        + "3. Нажмите Приложения\r\n"
                        + "4. Нажмите PS Vita\r\n"
                        + "5. Выберите h-encore и нажмите Скопировать\r\n"
                        + "6. Запустите h-encore в LiveArea\r\n"
                        + "     Если h-encore вылетает, то перезагрузите PS Vita и попробуйте снова\r\n\r\n"
                        + "Готово!"},

                { "warn_HashCompat", "Совместимость не гарантируется при использовании версий файлов, для которых это приложение не предназначено. Все равно продолжить?" },
                { "warn_DeleteExistingBittersmile", "Вы должны удалить существущий бэкап bittersmile из вашей директории QCMA directory. Если вы хотите её оставить, то просто переместите. Удалить?" },

                { "error_WebException", "Не удалось загрузить файл, проверьте ваше соединение." },
                { "error_Unknown", "Что-то пошло не так: {0}" },
                { "error_DirectoryNotFoundException", "Созданная директория, кажется, исчезла (может, она была удалена?), ранее директорию не удалось распаковать или вы хотите импортировать неподдерживаемый файл." },
                { "error_UnauthorizedAccessException", "Программа не получила доступа к директории. Попробуйте перезапустить программу от имени администратора." },
                { "error_FileNotFoundException",  "Созданный файл, кажется, исчез (может,он был удален?), ранее файл не удалось распаковать, или вы хотите импортировать неподдерживаемый файл."},
                { "error_InvalidOperationException",  "Файл был поврежден. Убедитесь в стабильности вашего интернет соединения."},
                { "error_TargetInvocationException", "Не удалось создать MD5 калькулятор." },
                { "error_Template", "Произошла ошибка {0}.\r\n\r\n{1}\r\n\r\nПовторите процесс. Если вы не можете решить проблему, пожалуйста, создайте issue в issue-трекере с этим кодом ошибки." },
                { "error_Redownload",  "Ошибка 1001-0105\r\n\r\nНе удалось установить файл {0}\r\n\r\nПроверьте подключение к интернету и попробуйте снова. Если все в порядке, а ошибка не пропадает, то создайте issue на GitHub."},

                { "log_SearchingForQCMA", "Поиск QCMA..." },
                { "log_FoundQCMA", "QCMA найден." },
                { "log_QCMANotFound", "QCMA не найден, он будет загружен." },
                { "log_KillingQCMA", "Убийство всех процессов QCMA..." },
                { "log_QCMARegistry", "Импорт данных реестра QCMA..." },
                { "log_ScrubAID", "Очистка AID" },
                { "log_Prompt", "Запрос информации пользователя..." },
                { "log_Done", "        Готово!" },
                { "log_WipeFiles", "Удаление старых файлов..." },
                { "log_Import", "Импорт файла для {0} прошел успешно." },
                { "log_DownloadValid", "Файл {0} уже загружен и проверен." },
                { "log_DownloadInvalid", "Файл {0} уже загружен, но хэш не прошел проверку, он будет загружен заново." },
                { "log_NotDownloaded", "Файл {0} не загружен или не импортирован, он будет загружен заново." },
                { "log_WorkingDirs", "Генерация рабочих директорий..." },
                { "log_CorrectLocation", "Файл {0} в правильной локации." },
                { "log_Importing", "Импорт {0}" },
                { "log_Downloading", "Загрузка {0}" },
                { "log_Extracting", "Распаковка {0}" },
                { "log_ExtractingPKG", "Распаковка bittersmile demo через pkg2zip..." },
                { "log_Trimming", "Удаление лишних файлов из bittersmile demo..." },
                { "log_MoveToHencore", "Перемещение {0} в рабочую директорию h-encore..." },
                { "log_MoveLicense", "Перемещение license файла..." },
                { "log_GetCMA", "Получение шифровочного ключа CMA используя AID {0}" },
                { "log_GotCMA", "CMA получен {0}" },
                { "log_Packaging", "Упаковка h-encore {0} через psvimgtools..." },
                { "log_MoveToQCMA", "Перемещение файлов h-encore в директорию QCMA APP...\r\n" },
                { "log_Finished", "auto h-encore выполнен!!!\r\n" },

                { "title_Main", "auto h-encore" },
                { "title_Import", "Импорт существующих файлов" },
                { "title_Warning", "Внимание" },
                { "title_Error", "Ошибка" }
            } },
            { "Português-BR",  new Dictionary<string, string> {
                { "lbl_ChooseLanguage", "Escolha o idioma:" },
                { "lbl_VersionText", "Versão auto h-encore " },
                { "lbl_Issues", "Rastreador de Erros" },
                        { "lbl_ConnectionMethod", "Como você irá conectar seu PS VITA para transferir o h-encore?" },
                { "lbl_UnplugVita", "Se seu Vita está conectado, desconecte e clique em Próximo." },
                { "lbl_InstallingUSB", "Instalando driver USB, por favor aguarde..." },
                { "lbl_WifiProblems", "Se seu Vita disser que precisa atualizar o firmware, desligue o Wifi e reinicie seu Vita. Isso também significa que você não pode transferir o h-encore através do Wifi sem atualizar!" },


                { "status_NoFile", "Nenhum arquivo selecionado, vai baixar." },
                { "status_Invalid", "Caminho do arquivo inválido." },
                { "status_Valid", "Arquivo selecionado e hash corresponde, vai importar." },
                { "status_BadHash", "Arquivo selecionado mas hash não corresponde, vai baixar." },
                { "status_Override", "Arquivo selecionado mas hash não corresponde. Reescrita de hash habilitada, vai importar." },
                { "status_Calculating", "Calculando hash do arquivo..." },

                { "txtblock_BeforeRunning", "O aplicativo irá baixar automaticamente o QCMA caso ainda não esteja instalado. O aplicativo irá abrir o QCMA e configurar automaticamente. Isso significa:\r\n    Se o QCMA não está instalado:\r\n        QCMA será baixado para uso local por esse programa.\r\n        Um driver USB será instalado se você escolher transferir por USB\r\n    Se o QCMA está instalado:\r\n        Sua instalação existente do QCMA será utilizada.\r\n        Nenhum driver USB será instalado e suas configurações não serão reescritas.\r\n\rBasicamente, você não precisa mais interagir com o QCMA a não ser que tenha problemas. Se tiver problemas, por favor reporte ao Rastreador de Erros."},
                { "txtblock_Import", "Se você já baixou algum ou todos os arquivos necessários, e não quer que baixe novamente, você pode selecioná-los aqui, para que seja feita a importação." },
                { "txtblock_USBInstructions", "Conecte seu PS Vita agora.\r\n\r\nSe nada acontecer:\r\n1. Abra o Gerenciador de Conteúdo no seu PS Vita\r\n2. Selecione Copiar Conteúdo\r\n3. Se solicitado: Selecione PC e USB\r\n\r\nSe ainda não funcionar, tente reiniciar seu computador e seu PS Vita e tente novamente (refaça os passos acima).\r\n\r\nSe ainda não funcionar, você deverá instalar o QCMA manualmente e escolher um driver usb que não seja o libusbk." },
                { "txtblock_WifiInstructions", "No seu PS Vita:\r\n1. Abra o Gerenciador de Conteúdo\r\n2. Selecione Copiar Conteúdo\r\n3. Escolha PC\r\n4. Escolha Wifi\r\n5.Selecione o nome do seu PC\r\n6. Coloque o código que aparece no seu PC\r\n\r\nSe não funcionar, tenha certeza que seu Vita e PC estão na mesma rede, ou reabra o aplicativo e tente por USB." },

                { "btn_Import", "Eu já baixei um ou todos os arquivos e gostaria de usá-los ao invés de baixá-los novamente" },
                { "btn_Ok", "OK" },
                { "btn_Close", "Fechar" },
                { "btn_Start", "Iniciar" },
                { "btn_Done", "Feito" },
                { "btn_Browse", "Procurar" },
                { "btn_Next", "Próximo" },
                { "btn_USB", "USB" },
                { "btn_Wifi", "Wi-Fi" },

                { "cbx_Trim", "Tirar o conteúdo excessivo do demo bitter smile (reduz o tamanho do app h-encore de ~240MB para ~13MB)" },
                { "cbx_DeleteExisting", "Deletar arquivos existentes (faça isso se alguma coisa deu errada antes)" },
                { "cbx_OverrideHashes", "Ignorar Diferenças de Hash dos Arquivos" },

                { "browse_QCMA", "Procure sua pasta PS Vita do QCMA (está localizada na opção Settings do QCMA, em Applications / Backups)" },
                { "browse_Generic", "Procure por " },

                { "info_Finish",  "Para finalizar a instalação do h-encore:\r\n"
                        + "1. Conecte seu PS Vita no seu PC usando o Gerenciador de Conteúdo como fez anteriormente (se ainda não foi conectado)\r\n"
                        + "     Se seu VITA disser que precisa atualizar, desligue o Wifi no seu Vita e reinicie o Vita\r\n"
                        + "2. No Gerenciador de Conteúdo, escolha PC -> Sistema PS Vita\r\n"
                        + "3. Selecione Aplicações\r\n"
                        + "4. Selecione PS Vita\r\n"
                        + "5. Selecione h-encore e clique em Copiar\r\n"
                        + "6. Abra o app h-encore na sua Live Area\r\n"
                        + "     Se travar na primeira vez, tente reiniciar seu Vita e inicie o app de novo\r\n\r\n"
                        + "Está feito!"},

                { "warn_HashCompat", "Compatibilidade não é garantida quando está usando versões de arquivos que essa aplicação não foi designada para tal. Continuar mesmo assim?" },
                { "warn_DeleteExistingBittersmile", "Você deve remover seu backup do bittersmile de sua pasta QCMA. Se deseja mantê-lo, deverá mover o backup agora. Remover?" },

                { "error_WebException", "Falha para baixar o arquivo. Por favor, verifique sua conexão." },
                { "error_Unknown", "Alguma coisa deu errado: {0}" },
                { "error_DirectoryNotFoundException", "Uma pasta que foi criada parece ter desaparecido (elas foram deletadas?) OU uma pasta falhou ao extrair OU você está usando um arquivo que não é suportado." },
                { "error_UnauthorizedAccessException", "A aplicação não tem acesso de escrita na pasta instalada. Tente reiniciar o aplicativo como Administrador." },
                { "error_FileNotFoundException",  "Um arquivo que foi criado parece ter desaparecido (eles foram deletados?) OU um arquivo falhou ao extrair OU você está usando um arquivo que não é suportado."},
                { "error_InvalidOperationException",  "Um download está corrompido. Tenha certeza que sua conexão é estável."},
                { "error_TargetInvocationException", "Falha ao criar calculadora MD5." },
                { "error_Template", "Erro {0} ocorrido.\r\n\r\n{1}\r\n\r\nPor favor reinicie o processo. Se você não conseguir resolver o problema, por favor crie um Problema no Rastreador de Erros (GitHub) com esse código." },
                { "error_Redownload",  "Erro 1001-0105\r\n\r\nFalha ao baixar arquivo {0}\r\n\r\nTenha certeza que sua Internet está conectada e/ou tente novamente. Se o erro persistir, por favor crie um Problema no Rastreador de Erros (GitHub)."},

                { "log_SearchingForQCMA", "Procurando por QCMA..." },
                { "log_FoundQCMA", "Achou QCMA." },
                { "log_QCMANotFound", "QCMA não encontrado, irá baixar." },
                { "log_KillingQCMA", "Fechando todos os processos QCMA..." },
                { "log_QCMARegistry", "Importando o registro de informações do QCMA..." },
                { "log_ScrubAID", "Limpando o valor AID" },
                { "log_Prompt", "Pedindo informações ao usuário..." },
                { "log_Done", "        Feito!" },
                { "log_WipeFiles", "Deletando arquivos antigos..." },
                { "log_Import", "Importação do arquivo {0} válida." },
                { "log_DownloadValid", "Arquivo {0} já baixado e é válido, não baixar denovo." },
                { "log_DownloadInvalid", "Arquivo {0} já baixado mas hash não corresponde, irá baixar novamente." },
                { "log_NotDownloaded", "Arquivo {0} não baixado ou não importado, irá baixar." },
                { "log_WorkingDirs", "Gerando diretórios de trabalho..." },
                { "log_CorrectLocation", "Arquivo {0} no lugar correto, pulando." },
                { "log_Importing", "Importando {0}" },
                { "log_Downloading", "Baixando {0}" },
                { "log_Extracting", "Extraindo {0}" },
                { "log_ExtractingPKG", "Extraindo demo do bittersmile com pkg2zip..." },
                { "log_Trimming", "Tirando conteúdo excessivo do demo bittersmile..." },
                { "log_MoveToHencore", "Movendo {0} para diretório de trabalho do h-encore..." },
                { "log_MoveLicense", "Movendo arquivo de licença..." },
                { "log_GetCMA", "Pegando chave de encriptação CMA usando AID {0}" },
                { "log_GotCMA", "Pegou chave de encriptação CMA {0}" },
                { "log_Packaging", "Empacotando h-encore {0} usando psvimgtools..." },
                { "log_MoveToQCMA", "Movendo arquivos h-encore para o diretório QCMA APP...\r\n" },
                { "log_Finished", "auto h-encore Finalizado!!\r\n" },

                { "title_Main", "auto h-encore" },
                { "title_Import", "Importar Arquivos Existentes" },
                { "title_Warning", "Atenção" },
                { "title_Error", "Erro" }
            } },
            { "Français",  new Dictionary<string, string> {
                { "lbl_ChooseLanguage", "Choisis la langue :" },
                { "lbl_VersionText", "auto h-encore version " },
                { "lbl_Issues", "Issue Tracker" },
                        { "lbl_ConnectionMethod", "Comment vous voulez connecter votre Vita pour transférer h-encore ?" },
                { "lbl_UnplugVita", "Si votre Vita est branché, débranché la, et cliquer sur suivant." },
                { "lbl_InstallingUSB", "Installation du pilote USB, Veuillez patientez svp..." },
                { "lbl_WifiProblems", "Si Votre Vita demande une mise à jour du firmware, veuillez désactiver la connexion Wifi et redémarré là. Ça signifie aussi que vous ne pouvez pas transférer h-encore via Wifi sans mettre à jour votre Vita !" },

                { "status_NoFile", "Aucun fichier n’a été sélectionné, pour être téléchargé." },
                { "status_Invalid", "Le chemin du fichier est invalide." },
                { "status_Valid", "Le fichier sélectionné et le Hash correspondent, importation." },
                { "status_BadHash", "Le fichier sélectionné et le Hash ne correspondent pas, pas d’importation." },
                { "status_Override", "Le fichier sélectionné et le Hash ne correspondant pas, mais le forcing est activé, importation." },
                { "status_Calculating", "Calcul du Hash du fichier..." },

                { "txtblock_BeforeRunning", "Cette application va télécharger QCMA automatiquement s'il n'est pas déjà installé. Elle va aussi le lancer et le contrôler. Ça veut dire:\r\n    Si QCMA n'est pas installé : \r\n        QCMA va être téléchargé pour un usage local par cette application. \r\n        Un pilote USB va être installé si vous choisirez de transférer via USB\r\n    Si QCMA est installé : \r\n        Votre installation QCMA existante va être utilisée. \r\n        Aucun pilote USB va être installé, et votre configuration ne va pas être modifiée. \r\n\r\nVous n'avez plus besoin d'interagir avec QCMA sauf s'il y a des problèmes. Si vous avez un problème, Veuillez soumettre un rapport dans l'issue Tracker."},
                { "txtblock_Import", "Si vous avez déjà téléchargé une partie ou tous les fichiers nécessaires, et que vous ne voulez pas que l’application les télécharge à nouveau, vous pouvez la sélectionner ici pour que le programme les importe." },
                { "txtblock_USBInstructions", "Connecter Votre PS Vita maintenant. \r\n\r\nSi rien ne se passe:\r\n1. Lancer le gestionnaire de contenu sur votre PS Vita \r\n2. Sélectionner Copier Du Contenu\r\n3. Si Demandé : Sélectionner PC et USB\r\n\r\nSi ça ne marche toujours pas, essayer de redémarrer Pc et votre Vita et ressayer (refaite les même étapes a nouveau).\r\n\r\nSi ça ne marche toujours pas, installer manuellement QCMA et sélectionner un autre pilote autre que libusbk." },
                { "txtblock_WifiInstructions", "Sur votre PS Vita:\r\n1. Lancer le gestionnaire de contenu sur votre PS Vita \r\n2. Sélectionner Copier Du Contenu\r\n3. Choisir PC\r\n4. Choisir Wifi\r\n5.Choisir votre PC\r\n6. Enter le code qui apparait sur votre PC\r\n\r\nSi ça ne marche pas, vérifier que votre PS Vita et votre PC sont sur le même réseau, ou relancer cette application et essayer la méthode USB." },

                { "btn_Import", "J'ai déjà téléchargé une partie ou tous les fichiers et je préfère les utiliser que de les télécharger à nouveau." },
                { "btn_Ok", "OK" },
                { "btn_Close", "Fermer" },
                { "btn_Start", "Démarrer" },
                { "btn_Done", "Fini" },
                { "btn_Browse", "Parcourir" },
                { "btn_Next", "Suivant" },
                { "btn_USB", "USB" },
                { "btn_Wifi", "Wi-Fi" },

                { "cbx_Trim", "Réduit l’excès de contenu de la démo bitter smile (réduire la taille de l'application h-encore de ~240MB a ~13MB)" },
                { "cbx_DeleteExisting", "Supprimer les fichiers existants (Faites ceci en cas d'erreur)" },
                { "cbx_OverrideHashes", "Ignorer les Hashes non conformes" },

                { "browse_QCMA", "Trouve le répertoire QCMA PS Vita (Trouvez ceci dans les paramètres de QCMA sous Applications / Backups)" },
                { "browse_Generic", "Parcourir pour " },

                { "info_Finish",  " Pour finir l'installation de h-encore:\r\n"
                        + "1. Connectez votre PS Vita sur Votre PC avec le Gestionnaire de Contenu comme auparavant (si elle n'est toujours pas connectée)\r\n"
                        + "     Si votre Vita demande une mise à jour, désactiver le wifi dans la Vita et redémarrer la\r\n"
                        + "4. Dans le gestionnaire de contenu, choisir PC -> PS Vita System\r\n"
                        + "5. Choisir Applications\r\n"
                        + "6. Choisir PS Vita\r\n"
                        + "7. Choisir h-encore et appuyez sur Copier\r\n"
                        + "8. Exécutez la bulle h-encore app depuis Live Area\r\n"
                        + "     Si ça plante à la 1ere utilisation, redémarrer votre Vita et lancez la bulle de nouveau\r\n\r\n"
                        + "Fini !"},

                { "warn_HashCompat", "La compatibilité avec cette version n'est pas sûre. On continue quand même ?" },
                { "warn_DeleteExistingBittersmile", "Vous devez supprimer le backup existant de bittersmile backup du répertoire QCMA. Si vous voulez le garder, déplacez-le maintenant. Supprimer ?" },

                { "error_WebException", "Erreur dans le téléchargement du fichier. Vérifiez votre connexion internet." },
                { "error_Unknown", "Quelque chose ne vas pas : {0}" },
                { "error_DirectoryNotFoundException", "Les répertoires qui ont étés créés ont disparu (Ils sont peut-être supprimés?) Ou bien, un répertoire n'a pas pu être extrait, ou alors, vous êtes en train d'utiliser une version de fichier non supporté." },
                { "error_UnauthorizedAccessException", "L'application n'a pas le droit d'accès au répertoire ou elle a été installée. Essayer de lancer l'application en mode Administrateur." },
                { "error_FileNotFoundException",  "Les fichiers qui ont étés créés ont disparus (Ils sont peut-être supprimés?) Ou bien un fichier n'a pas pu être extrait, ou alors, Vous êtes en train d'utiliser une version de fichier non supporté."},
                { "error_InvalidOperationException",  "Un téléchargement est corrompu. Vérifiez que votre connexion internet est stable."},
                { "error_TargetInvocationException", "Erreur dans la création du calculateur MD5." },
                { "error_Template", "Erreur {0} apparue. \r\n\r\n{1}\r\n\r\n Réessayez le processus. Si vous ne pouvez pas résoudre ce problème, S'il vous plait créez un rapport d'erreur dans l'Issue Tracker avec ce code d'erreur." },
                { "error_Redownload",  "Erreur 1001-0105\r\n\r\n Impossible de télécharger le fichier {0}\r\n\r\n Assurer vous que vous êtes connecté à internet et réessayez. Si ça ne marche toujours pas, s'il vous plait créez un rapport d'erreur sur le GitHub de l'application."},

                { "log_SearchingForQCMA", "Recherche de QCMA..." },
                { "log_FoundQCMA", "QCMA Trouvé." },
                { "log_QCMANotFound", "QCMA introuvable, Téléchargement." },
                { "log_KillingQCMA", "Fermeture des processus QCMA..." },
                { "log_QCMARegistry", "Importation des information QCMA depuis le registre..." },
                { "log_ScrubAID", "Nettoyage de la valeur AID" },
                { "log_Prompt", "Demande d'information a l’utilisateur..." },
                { "log_Done", "        Fini !" },
                { "log_WipeFiles", "Suppression des anciens fichiers..." },
                { "log_Import", "Importation de fichier pour le fichier {0} valide." },
                { "log_DownloadValid", "Fichier {0} déjà téléchargé et valide, Pas de re-téléchargement." },
                { "log_DownloadInvalid", "Fichier {0} déjà téléchargé mais le Hash ne correspond pas, re-téléchargement." },
                { "log_NotDownloaded", "Fichier {0} pas encore téléchargé ou bien importé, téléchargement." },
                { "log_WorkingDirs", "Génération des répertoires temporaires..." },
                { "log_CorrectLocation", "Fichier {0} dans le bon répertoire, saut du fichier." },
                { "log_Importing", "Importation de {0}" },
                { "log_Downloading", "Téléchargement de {0}" },
                { "log_Extracting", "Extraction de {0}" },
                { "log_ExtractingPKG", "Extraction de la démo bittersmile avec pkg2zip..." },
                { "log_Trimming", "Suppression des fichiers non nécessaires de la demo bittersmile..." },
                { "log_MoveToHencore", "Déplacement de {0} a le répertoire temporaire de h-encore..." },
                { "log_MoveLicense", "Déplacement du fichier de licence..." },
                { "log_GetCMA", "Obtention de la clé de cryptage CMA utilisant L’AID {0}" },
                { "log_GotCMA", "Clé de cryptage CMA obtenu {0}" },
                { "log_Packaging", "Mise en paquet de h-encore {0} en utilisant psvimgtools..." },
                { "log_MoveToQCMA", "Déplacement des fichiers h-encore à la répertoire QCMA APP ...\r\n" },
                { "log_Finished", "Auto h-encore a terminé son programme!\r\n" },

                { "title_Main", "auto h-encore" },
                { "title_Import", "Importer les fichiers existants" },
                { "title_Warning", "Attention" },
                { "title_Error", "Erreur" }
            } },
            { "German",  new Dictionary<string, string> {
                { "lbl_ChooseLanguage", "Wähle eine Sprache:" },
                { "lbl_VersionText", "auto h-encore version " },
                { "lbl_Issues", "Issue Tracker" },
                        { "lbl_ConnectionMethod", "Wie möchtest du deine PS Vita verbinden, um h-encore zu übertragen?" },
                { "lbl_UnplugVita", "Wenn deine Vita am PC angeschlossen ist, entferne sie und klicke dann auf Weiter." },
                { "lbl_InstallingUSB", "USB Treiber wird installiert, bitte warten..." },
                { "lbl_WifiProblems", "Wenn deine Vita ein Update ausführen möchte, deaktiviere WiFi und starte deine Vita neu. Das bedeutet auch, dass du h-encore nicht über WiFi übertragen kannst, ohne ein Update durchzuführen!" },

                { "status_NoFile", "Keine Datei ausgewählt, wird heruntergeladen." },
                { "status_Invalid", "Dateipfad ist ungültig." },
                { "status_Valid", "Datei ausgewählt und Hash stimmt überein, wird importiert." },
                { "status_BadHash", "Datei ausgewählt, aber Hash stimmt nicht überein, wird heruntergeladen." },
                { "status_Override", "Datei ausgewählt, aber Hash stimmt nicht überein. Übergehen des Hashs aktiviert, Datei wird importiert." },
                { "status_Calculating", "Berechne Hash..." },

                { "txtblock_BeforeRunning", "Die Anwendung wird automatisch QCMA herunterladen, sollte es nicht installiert sein. Außerdem wird sie es automatisch starten und verwalten. Das bedeutet:\r\n    Wenn QCMA nicht installiert ist:\r\n    QCMA wird für die lokale Nutzung dieses Programms heruntergeladen.\r\n    Ein USB Treiber wird installiert, falls du die Übertragung via USB wählst.\r\n    Wenn QCMA installiert ist:\r\n    Deine existierende QCMA-Installation wird genutzt.\r\n    Keine neuen Treiber werden installiert und deine Einstellungen werden nicht überschrieben.\r\n\r\nDu musst nicht mehr mit QCMA interagieren, außer es gibt Probleme. Wenn die Schwierigkeiten hast, füge bitte ein Issue im Issue Tracker hinzu."},
                { "txtblock_Import", "Wenn du bereits einige oder alle der benötigten Dateien heruntergeladen hast und du nicht möchtest, dass das Programm sie erneut herunterlädt, dann kannst du sie hier auswählen, damit das Programm sie importiert." },
                { "txtblock_USBInstructions", "Verbinde deine PS Vita jetzt.\r\n\r\nWenn nichts passiert:\r\n1. Starte den Inhaltsmanager auf deiner PS Vita.\r\n2. Wähle Inhalte kopieren\r\n3. Wenn gefragt wird: Wähle PC und USB\r\n\r\nFalls es nun noch immer nicht funktioniert, starte deinen Computer und PS Vita neu und versuche den Vorgang erneut.\r\n\r\nFalls es immer nicht funktioniert, muss du möglicherweise QCMA manuell installieren und einen anderen Treiber als libusbk auswählen." },
                { "txtblock_WifiInstructions", "Auf deiner PS Vita:\r\n1. Starte den Inhaltsmanager\r\n2. Wähle Inhalte kopieren\r\n3. Wähle PC\r\n4. Wähle WiFi\r\n5. Wähle den Namen deines PCs\r\n6. Gib den Code ein, der auf deinem PC erscheint.\r\n7. Wähle Registrieren\r\n\r\nFalls es nicht funktioniert, stelle sicher dass dein PC und deine Vita mit dem selben Netzwerk verbunden sind, oder starte diese Programm neu und wähle USB." },

                { "btn_Import", "Ich habe bereits einige oder alle Dateien heruntergeladen" },
                { "btn_Ok", "OK" },
                { "btn_Close", "Schließen" },
                { "btn_Start", "Start" },
                { "btn_Done", "Fertig" },
                { "btn_Browse", "Durchsuchen" },
                { "btn_Next", "Weiter" },
                { "btn_USB", "USB" },
                { "btn_Wifi", "Wi-Fi" },

                { "cbx_Trim", "Überflüssigen Inhalt der Bitter Smile Demo entfernen (Reduziert die Größe der h-encore-App von ~240MB auf ~13MB)" },
                { "cbx_DeleteExisting", "Bestehende Dateien löschen (tue dies, falls zuvor etwas schiefgelaufen ist)" },
                { "cbx_OverrideHashes", "Ignoriere Prüfsummen-Fehler" },

                { "browse_QCMA", "Finde deinen QCMA-PS-Vita-Ordner (Du findest ihn in den QCMA-Einstellungen unter Applications / Backups)" },
                { "browse_Generic", "Suche nach " },

                { "info_Finish",  "Um deine h-encore-Installation abzuschließen:\r\n"
                        + "1. Verbinde deine PS Vita mit deinem Computer mithilfe des Inhaltsmanagers, wie du es bereits getan hast (Falls sie nicht noch immer verbunden ist).\r\n"
                        + "     Wenn die Vita meldet, dass du die Firmware aktualisieren musst, deaktiviere das WLAN auf deiner Vita und starte die Konsole neu.\r\n"
                        + "4. Wähle im Content Manager, PC -> PS Vita System\r\n"
                        + "5. Wähle Applikationen\r\n"
                        + "6. Wähle PS Vita\r\n"
                        + "7. Selektiere h-encore und drücke Kopieren\r\n"
                        + "8. Starte die h-encore-App von der Live Area aus\r\n"
                        + "     Wenn sie beim ersten Mal abstürzt, starte die Vita neu und starte die App erneut\r\n\r\n"
                        + "Fertig!"},

                { "warn_HashCompat", "Die Kompatibilität wird nicht gewährleistet, wenn du Versionen von Dateien verwendest, die dafür nicht vorgesehen waren. Trotzdem fortfahren?" },
                { "warn_DeleteExistingBittersmile", "Du musst das bestehende Backup von Bitter Smile aus deinem QCMA-Ordner entfernen. Falls du es behalten willst, verschiebe es jetzt. Soll es gelöscht werden?" },

                { "error_WebException", "Fehler beim Download. Bitte überprüfe deine Internet-Verbindung." },
                { "error_Unknown", "Irgendwas ist schiefgelaufen: {0}" },
                { "error_DirectoryNotFoundException", "Ein Ordner, der erstellt wurde scheint verschwunden zu sein (Wurde er gelöscht?) ODER ein Ordner konnte zuvor nicht entpackt werden ODER du verwendest einen nicht unterstützten Datei-Import." },
                { "error_UnauthorizedAccessException", "Das Programm hat keinen Schreibzugriff auf den Ordner, in dem es installiert wurde. Führe das Programm als Administrator erneut aus." },
                { "error_FileNotFoundException",  "Eine Datei, die erstellt wurde, scheint verschwunden zu sein. (Wurde sie gelöscht?) ODER eine Datei konnte nicht entpackt werden ODER du verwendest einen nicht unterstützten Datei-Import."},
                { "error_InvalidOperationException",  "Ein Download ist defekt. Stelle sicher, dass dein Internetzugang fehlerfrei funktioniert."},
                { "error_TargetInvocationException", "Fehler beim Erstellen des MD5-Rechners." },
                { "error_Template", "Fehler {0} aufgetreten.\r\n\r\n{1}\r\n\r\nBitte versuche es erneut. Falls du das Problem nicht lösen kannst, dann erstelle einen Fehlerbericht im Issue Tracker mit diesem Code." },
                { "error_Redownload",  "Fehler 1001-0105\r\n\r\nFehler beim Download der Datei {0}\r\n\r\nStelle sicher, dass du Zugang zum Internet hast und/oder versuche es nochmal. Wenn es immer noch nicht klappt, dann erstelle einen Fehlerbericht im Issue Tracker."},

                { "log_SearchingForQCMA", "Suche nach QCMA..." },
                { "log_FoundQCMA", "QCMA gefunden." },
                { "log_QCMANotFound", "QCMA nicht gefunden. Es wird heruntergeladen." },
                { "log_KillingQCMA", "Laufende QCMA Prozesse werden geschlossen..." },
                { "log_QCMARegistry", "QCMA Registry Informationen werden importiert..." },
                { "log_ScrubAID", "Setze AID-Wert zurück" },
                { "log_Prompt", "Nutzer wird nach Informationen gefragt..." },
                { "log_Done", "        Fertig!" },
                { "log_WipeFiles", "Lösche alte Dateien..." },
                { "log_Import", "Datei-Import für {0} gültig." },
                { "log_DownloadValid", "Datei {0} bereits heruntergeladen und gültig, sie wird nicht erneut heruntergeladen." },
                { "log_DownloadInvalid", "Datei {0} bereits heruntergeladen, aber der Hash stimmt nicht überein, Datei wird erneut heruntergeladen." },
                { "log_NotDownloaded", "Datei {0} nicht heruntergeladen oder importiert, Datei wird heruntergeladen." },
                { "log_WorkingDirs", "Erstelle Arbeitsverzeichnisse..." },
                { "log_CorrectLocation", "Datei {0} an der richtigen Stelle, überspringen." },
                { "log_Importing", "Importiere {0}" },
                { "log_Downloading", "Downloade {0}" },
                { "log_Extracting", "Entpacke {0}" },
                { "log_ExtractingPKG", "Entpacke Bitter Smile Demo mit pkg2zip..." },
                { "log_Trimming", "Entferne überflüssigen Inhalt aus der Bitter Smile Demo..." },
                { "log_MoveToHencore", "Bewege {0} ins h-encore Arbeitsverzeichnis..." },
                { "log_MoveLicense", "Verschiebe Lizenzdatei..." },
                { "log_GetCMA", "Hole CMA-Verschlüsselungs-Key mit der AID {0}" },
                { "log_GotCMA", "CMA-Verschlüsselungs-Key erhalten: {0}" },
                { "log_Packaging", "Verpacke h-encore {0} mittels psvimgtools..." },
                { "log_MoveToQCMA", "Verschiebe h-encore-Dateien in den QCMA APP-Ordner...\r\n" },
                { "log_Finished", "auto h-encore fertig!!\r\n" },

                { "title_Main", "auto h-encore" },
                { "title_Import", "Importiere bestehende Dateien" },
                { "title_Warning", "Warnung" },
                { "title_Error", "Fehler" }
                } },
            { "日本語(Japanese)",  new Dictionary<string, string> {
                { "lbl_ChooseLanguage", "言語を選択:" },
                { "lbl_VersionText", "auto h-encore Ver." },
                { "lbl_Issues", "Issue Tracker(バグ情報/提供)" },
                { "lbl_ConnectionMethod", "PSVitaのPCへの接続方法を選択して下さい" },
                { "lbl_UnplugVita", "Vitaが接続されている場合はUSBを抜いて「次へ」をクリックします" },
                { "lbl_InstallingUSB", "USBドライバをPCにインストールしています。しばらくお待ちください..." },
                { "lbl_WifiProblems", "h-encoreはPS Vitaが最新のFWでない場合はWi-Fi接続で転送する事は出来ません。接続中に本体更新が要求されたらWi-Fiを切ってPS Vitaを再起動して下さい" },

                { "status_NoFile", "ファイルが選択されていません。ダウンロードします" },
                { "status_Invalid", "ファイルパスが無効です" },
                { "status_Valid", "選択したファイルとハッシュの一致を確認してインポートします" },
                { "status_BadHash", "選択したファイルのハッシュが一致しません" },
                { "status_Override", "選択したファイルのハッシュが一致しません。ハッシュオーバーライドを有効化してインポートします" },
                { "status_Calculating", "ファイルハッシュを計算中..." },

                { "txtblock_BeforeRunning", "QCMAがインストールされていない場合、[auto h-encore]は自動的にQCMAをダウンロード、起動して管理します:\r\n    QCMAがインストールされていない場合:\r\n        [auto h-encore]はQCMAを使用するためにダウンロードします\r\n        USB経由で転送する場合はUSBドライバがインストールされます\r\n    QCMAがインストールされている場合:\r\n        既存のQCMAが使用されます\r\n        USBドライバはインストールされず、設定は上書きされません\r\n\r\n基本的にQCMAを操作する必要は有りません。 問題がある場合は「Issue Tracker」にレポートを提出して下さい"},
                { "txtblock_Import", "既に必要なファイルの一部を用意していてダウンロードする必要の無いファイルが有る場合は、ここでインポートするファイルを選択できます" },
                { "txtblock_USBInstructions", "PS Vitaを接続して下さい\r\n\r\n何も起こらない場合:\r\n1. PS Vitaで「コンテンツ管理」を起動\r\n2. 「コンテンツをコピーする」を選択\r\n3. プロンプトが表示されたら: 「パソコン→PS Vita」を選択\r\n\r\n動作しない場合はPCとPS Vitaを再起動して再試行（上記の手順を再度実行）\r\n\r\nそれでも動作しない場合はQCMAを手動でインストールし、libusbk以外のドライバを選択する必要があります" },
                { "txtblock_WifiInstructions", "PS Vita側の作業:\r\n1. コンテンツ管理を起動\r\n2. 「コンテンツをコピーする」を選択\r\n3. 「パソコン→PS Vita」を選択\r\n4. 「WiFi」を選択\r\n5. 接続したいPCを選択\r\n6. PCに表示されるコードを入力\r\n7. 「登録」を選択\r\n\r\n動作しない場合はVitaとPCが同じネットワークに接続されているか確認するか[auto h-encore]を再実行してUSB接続を試して下さい" },

                { "btn_Import", "既に用意されているファイルを使用する" },
                { "btn_Ok", "はい" },
                { "btn_Close", "閉じる" },
                { "btn_Start", "スタート" },
                { "btn_Done", "完了" },
                { "btn_Browse", "参照" },
                { "btn_Next", "次へ" },
                { "btn_USB", "USB" },
                { "btn_Wifi", "Wi-Fi" },

                { "cbx_Trim", "bitter smile.体験版から余分なデータを削除(h-encoreアプリのサイズを240MBから13MBに減らす)" },
                { "cbx_DeleteExisting", "既存のファイルを削除(エラーが起きた場合)" },
                { "cbx_OverrideHashes", "不一致のファイルハッシュを無視" },

                { "browse_Generic", "参照 " },

                { "info_Finish",  "h-encoreのインストールを完了するには:\r\n"
                        + "1. 前回同様「コンテンツ管理」を使用してPS VitaをPCに接続(接続していない場合)\r\n"
                        + "     Vitaを更新する必要が有ると表示されたら、WiFiをオフにしてコンソールを再起動\r\n"
                        + "2. コンテンツ管理で「パソコン→PS Vita」を選択\r\n"
                        + "3. 「アプリケーション」を選択\r\n"
                        + "4. 「PS Vita」を選択\r\n"
                        + "5. 「h-encore」を選択して「コピー」を押す\r\n"
                        + "6. ホーム画面から「h-encore」を起動\r\n"
                        + "     クラッシュした場合は、Vitaを再起動してもう一度起動\r\n\r\n"
                        + "以上です"},

                { "warn_HashCompat", "[auto h-encore]が想定していないバージョンのアプリを使用している場合、互換性は保証できません。続けますか?" },
                { "warn_DeleteExistingBittersmile", "「bittersmile.体験版」のバックアップをQCMAディレクトリから削除します。保護したい場合は今すぐ移動して下さい" },

                { "error_WebException", "ダウンロードできませんでした。インターネット接続を確認して下さい" },
                { "error_Unknown", "例外的なエラーが発生しました: {0}" },
                { "error_DirectoryNotFoundException", "作成されたディレクトリは削除されているか、抽出されなかったか、サポートされていないファイルインポートを使用しています" },
                { "error_UnauthorizedAccessException", "[auto h-encore]にはインストールされたディレクトリへのアクセス権がありません。アプリケーションを管理者として再実行して下さい" },
                { "error_FileNotFoundException",  "作成されたディレクトリは削除されています。またはディレクトリが抽出されなかったかサポートされていないファイルインポートを使用しています"},
                { "error_InvalidOperationException",  "ダウンロードに失敗しました。ネットワークの安定性を確認して下さい"},
                { "error_TargetInvocationException", "MD5の作成に失敗しました" },
                { "error_Template", "エラー {0} が発生しました\r\n\r\n{1}\r\n\r\nプロセスを再試行して下さい。問題を解決できない場合は、エラーコードを[Issue Tracker]で報告して下さい" },
                { "error_Redownload",  "エラー 1001-0105\r\n\r\nファイルのダウンロードに失敗しました {0}\r\n\r\nインターネットが接続されているかどうかを確認し、再実行しても問題が解決しない場合は[Issue Tracker]で報告して下さい"},

                { "log_SearchingForQCMA", "QCMAを探しています..." },
                { "log_FoundQCMA", "QCMAが見つかりました" },
                { "log_QCMANotFound", "QCMAが見つかりません。ダウンロードします" },
                { "log_KillingQCMA", "実行中のQCMAプロセスを強制終了中..." },
                { "log_QCMARegistry", "QCMAレジストリ情報のインポート中..." },
                { "log_ScrubAID", "AIDを検索中..." },
                { "log_Prompt", "ユーザーに情報の入力を促しています..." },
                { "log_Done", "        完了" },
                { "log_WipeFiles", "古いファイルを削除中..." },
                { "log_Import", "ファイル {0} のインポートが有効です" },
                { "log_DownloadValid", "ファイル {0} は既にダウンロードているためダウンロードされません" },
                { "log_DownloadInvalid", "ファイル {0} は既にダウンロードされていますが、ハッシュが一致しません" },
                { "log_NotDownloaded", "ファイル {0} はダウンロードまたはインポートされていないため、ダウンロードします" },
                { "log_WorkingDirs", "作業用ディレクトリを生成中..." },
                { "log_CorrectLocation", "ファイル {0} を正しい位置に保存中..." },
                { "log_Importing", "{0} をインポート中..." },
                { "log_Downloading", "{0} をダウンロード中..." },
                { "log_Extracting", "{0} を抽出中..." },
                { "log_ExtractingPKG", "pkg2zipで「bitter smile.体験版」を抽出中..." },
                { "log_Trimming", "「bitter smile.体験版」から余分なデータを抜き出し中..." },
                { "log_MoveToHencore", "{0} をh-encore作業用ディレクトリに移動中..." },
                { "log_MoveLicense", "ライセンスファイルを移動中..." },
                { "log_GetCMA", "AID {0} からCMA暗号化キーを生成中..." },
                { "log_GotCMA", "CMA暗号化キー {0} を生成しました" },
                { "log_Packaging", "psvimgtoolsでh-encore {0} をパッキング中..." },
                { "log_MoveToQCMA", "h-encoreファイルをQCMA APPディレクトリに移動中...\r\n" },
                { "log_Finished", "自動h-encore生成が完了しました\r\n" },

                { "title_Main", "auto h-encore" },
                { "title_Import", "既存のファイルをインポート" },
                { "title_Warning", "警告" },
                { "title_Error", "エラー" }
                } },
            { "Türkçe",  new Dictionary<string, string> {
                { "lbl_ChooseLanguage", "Dili Seçin:" },
                { "lbl_VersionText", "auto h-encore versiyonu " },
                { "lbl_Issues", "Hata Takibi" },
                { "lbl_ConnectionMethod", "H-encore yüklemesi için Vitanızı nasıl bağlamayı planlıyorsunuz?" },
                { "lbl_UnplugVita", "Eğer Vitanız bağlı ise, bağlantıyı kesin ve İleri'ye tıklayın." },
                { "lbl_InstallingUSB", "USB sürücüsü yükleniyor, lütfen bekleyin..." },
                { "lbl_WifiProblems", "Eğer Vitanız versiyon güncellemesi yapmanızı istiyorsa, WiFi bağlantısını kapatın ve Vitanızı yeniden başlatın. Bu durum güncelleme yapmadan Wifi kullanarak h-encore yüklemesi yapamayacağınız anlamına gelir!" },

                { "status_NoFile", "Hiçbir dosya seçilmedi, indiriliyor." },
                { "status_Invalid", "Dosya dizini geçersiz." },
                { "status_Valid", "Dosya seçildi ve bütünlüğü doğrulandı, aktarılıyor." },
                { "status_BadHash", "Dosya seçildi ve bütünlüğü doğrulanamadı, indiriliyor." },
                { "status_Override", "Dosya seçildi ancak bütünlüğü sağlanamadı. Bütünlük sağlanılarak aktarılıyor." },
                { "status_Calculating", "Dosya bütünlüğü kontrol ediliyor..." },

                { "txtblock_BeforeRunning", "Uygulama QCMA yüklü değilse otomatik olarak indirecektir. Ayrıca çalıştırıp ayarlamaları otomatik bir şekilde yapacaktır. Eğer:\r\n    QCMA yüklü değil ise:\r\n        QCMA bu program tarafından kullanılmak üzere indirilecektir.\r\n        USB ile uygulama aktarımını seçerseniz USB sürücüsü de yüklenecektir\r\n    Eğer QCMA yüklü ise:\r\n        Varolan yükleme kullanılacaktır.\r\n        Yeni USB sürücüleri yüklenmeyecek ve varolan ayarlarınız değiştirilmeyecektir.\r\n\r\nÖzetle, herhangi bir problem yaşamadıkça QCMA program tarafından yönetilecektir. Eğer hata alırsanız, lütfen Hata Takibi bölümünden hata bildiriminde bulunun."},
                { "txtblock_Import", "Eğer gerekli dosyaların bazılarını veya tamamını indirmiş ve programın tekrar indirmesini istemiyorsanız, buradan dosyaları seçip programa aktarabilirsiniz." },
                { "txtblock_USBInstructions", "Şimdi PS Vitanızı bağlayın.\r\n\r\nIEğer tanımlanmazsa:\r\n1. Vitanızdan İçerik Yöneticisini çalıştırın\r\n2. İçeriği kopyalayı seçin\r\n3. Sorulması durumunda: Bilgisayar ardından USB kablosunu seçin\r\n\r\nEğer hala çalışmıyorsa, bilgisayarınızı ve Vitanızı yeniden başlatın ve yeniden deneyin (yukarıdaki adımları).\r\n\r\nBunlara rağmen çalışmıyorsa, QCMA uygulamasını kendiniz yükleyin ve libusbk dışında bir USB sürücüsü kullanın." },
                { "txtblock_WifiInstructions", "PS Vitanızdan:\r\n1. İçerik Yöneticisini çalıştırın\r\n2. İçeriği Kopyalayı seçin\r\n3. Bigisayarı seçin\r\n4. Wifiyi seçin\r\n5. Bilgisayarınızın adını seçin\r\n6. Bilgisayarınızda çıkan kodu girin\r\n7. Kaydeti seçin\r\n\r\nEğer çalışmazsa, Vita ve bilgisayarınızın aynı ağa bağlı olduğundan emin olun, veya uygulamayı yeniden başlatıp USB ile bağlanın." },

                { "btn_Import", "Gerekli dosyaların bazıları veya tamamını indirdim, yeniden indirmek yerine varolanları kullanmak istiyorum" },
                { "btn_Ok", "Tamam" },
                { "btn_Close", "Kapat" },
                { "btn_Start", "Başlat" },
                { "btn_Done", "Bitti" },
                { "btn_Browse", "Gözat" },
                { "btn_Next", "İleri" },
                { "btn_USB", "USB" },
                { "btn_Wifi", "Wi-Fi" },

                { "cbx_Trim", "Bitter Smile demosundan gereksiz dosyaları temizle (h-encore boyutu ~240MB'den ~13MB'ye düşecektir)" },
                { "cbx_DeleteExisting", "Varolan dosyaları sil (Hata aldıysanız bunu yapın)" },
                { "cbx_OverrideHashes", "Bütünlüğü sağlanamayan dosyaları yine de kullan" },

                { "browse_Generic", "Gözat " },

                { "info_Finish",  "h-encore yüklemesini tamamlamak için:\r\n"
                        + "1. Daha önce yaptığınız gibi PS Vitanızı bilgisayarınıza yeniden bağlayın (eğer bağlı ise devam edin)\r\n"
                        + "     Eğer Vitanız versiyon güncellemesi yapmanızı istiyorsa, WIFI bağlantısını kapatın ve Vitanızı yeniden başlatın\r\n"
                        + "2. İçerik yöneticisi, İçeriği kopyala, Bilgisayar -> PS Vita Sistemini seçin\r\n"
                        + "3. Uygulamaları seçin\r\n"
                        + "4. PS Vita'yı seçin\r\n"
                        + "5. h-encore uygulamasını seçip Kopyala'ya basın\r\n"
                        + "6. Live Area ekranından h-encore uygulamasını çalıştırın\r\n"
                        + "     Uygulama ilk çalıştırdığınızda çökerse, Vitanızı yeniden başlatmayı ve uygulamayı yeniden çalıştırmayı deneyin\r\n\r\n"
                        + "Tamamlandı!"},

                { "warn_HashCompat", "Programın dizayn edildiği uygulamaların güncel versiyonları kullanılmadığında uyumluluk garantisi verilmemektedir. Yine de devam et?" },
                { "warn_DeleteExistingBittersmile", "QCMA dizininde varolan bittersmile demosunu kaldırmak zorundasınız. Silinmesini istemiyorsanız, başka bir dizine taşıyın. Silinsin mi?" },

                { "error_WebException", "Dosya indirme işlemi başarısız oldu. İnternet bağlantınızı kontrol edin." },
                { "error_Unknown", "{0} için bir hata oluştu." },
                { "error_DirectoryNotFoundException", "Oluşturulan dizin bulunamadı (silinmiş olabilir) VEYA dizinde çıkarma işlemi başarısız olmuş olabilir VEYA desteklenmeyen uzantıda dosya aktardınız." },
                { "error_UnauthorizedAccessException", "Uygulama yüklendiği dizinde değişiklik yapma yetkisine sahip değil. Uygulamayı Yönetici olarak tekrar çalıştırmayı deneyin." },
                { "error_FileNotFoundException",  "Oluşturulan dosya bulunamadı (silinmiş olabilir) VEYA dosya çıkarılırken başarısız olunmuş olabilir VEYA desteklenmeyen uzantıda dosya aktardınız."},
                { "error_InvalidOperationException",  "Bir dosya tam indirilemedi. Lütfen internet bağlantınızın stabilliğini kontrol ediniz."},
                { "error_TargetInvocationException", "MD5 hesaplayıcı oluşturulurken başarısız olundu." },
                { "error_Template", "{0} için hata oluştu.\r\n\r\n{1}\r\n\r\nLütfen işlemleri tekrarlayın. Eğer yine hata alırsanız, lütfen hata takibi bölümünden aldığınız hata koduyla birlikte hata bildiriminde bulunun." },
                { "error_Redownload",  "1001-0105 Hatası\r\n\r\n {0} için dosya indirme başarısız oldu\r\n\r\nİnternet bağlantınızı kontrol edin ve/veya yeniden deneyin. Eğer hala çalışmazsa, Hata Bildirimi bölümünden Github üzerinden bildirimde bulunun."},

                { "log_SearchingForQCMA", "QCMA uygulaması aranıyor..." },
                { "log_FoundQCMA", "QCMA uygulaması bulundu." },
                { "log_QCMANotFound", "QCMA uygulaması bulunamadı, indiriliyor." },
                { "log_KillingQCMA", "Arka planda çalışan QCMA işlemleri kapatılıyor..." },
                { "log_QCMARegistry", "QCMA ayarları aktarılıyor..." },
                { "log_ScrubAID", "AID verisi temizleniyor" },
                { "log_Prompt", "Kullanıcı bilgisi isteniyor..." },
                { "log_Done", "        Tamamlandı!" },
                { "log_WipeFiles", "Gereksiz dosyalar siliniyor..." },
                { "log_Import", "{0} dosyası için dizin geçerli." },
                { "log_DownloadValid", "{0} dosyası daha önce indirildi ve doğrulandı, tekrar indirilmeyecek." },
                { "log_DownloadInvalid", "{0} dosyası bulundu ancak bütünlüğü sağlanamadı, tekrar indiriliyor." },
                { "log_NotDownloaded", "{0} dosyası eksik veya aktarılmadı, indiriliyor." },
                { "log_WorkingDirs", "Dizinler oluşturuluyor..." },
                { "log_CorrectLocation", "{0} dosyası dizinde bulundu, sonraki adıma geçiliyor." },
                { "log_Importing", "{0} Aktarılıyor" },
                { "log_Downloading", "{0} İndiriliyor" },
                { "log_Extracting", "{0} Çıkartılıyor" },
                { "log_ExtractingPKG", "pkg2zip ile bittersmile demosu çıkartılıyor..." },
                { "log_Trimming", "Bittersmile demosundan gereksiz dosyalar temizleniyor..." },
                { "log_MoveToHencore", "{0} h-encore dizinine taşınıyor..." },
                { "log_MoveLicense", "Lisans dosyası taşınıyor..." },
                { "log_GetCMA", "AID {0} için CMA şifreleme anahtarı oluşturuluyor" },
                { "log_GotCMA", "{0} için CMA şifreleme anahtarı oluşturuldu" },
                { "log_Packaging", "psvimgtools ile h-encore {0} arşivleniyor..." },
                { "log_MoveToQCMA", "h-encore dosyaları QCMA APP dizinine taşınıyor...\r\n" },
                { "log_Finished", "auto h-encore yüklemesi tamamlandı!!\r\n" },

                { "title_Main", "auto h-encore" },
                { "title_Import", "Varolan Dosyaları Aktar" },
                { "title_Warning", "Uyarı" },
                { "title_Error", "Hata" }
            } }
        };
        
        public static Dictionary<string, string> MountedLanguage = Languages["English"];
    }
}
