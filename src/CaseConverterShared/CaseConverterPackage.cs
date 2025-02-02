﻿using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CaseConverter.Options;
using Microsoft.VisualStudio.Shell;

namespace CaseConverter
{
    /// <summary>
    /// 拡張機能として配置されるパッケージです。
    /// </summary>
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration("#110", "#112", "2.2", IconResourceID = 400)] // Visual Studio のヘルプ/バージョン情報に表示される情報です。
    [Guid(PackageGuidString)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [ProvideOptionPage(typeof(GeneralOptionPage), PackageName, "General", 100, 101, true)]
    [ProvideProfile(typeof(GeneralOptionPage), PackageName, "General", 110, 110, true)]
    public sealed class CaseConverterPackage : AsyncPackage
    {
        /// <summary>
        /// パッケージのIDです。
        /// </summary>
        public const string PackageGuidString = "3293cb25-75b9-4d5a-a248-ea3cf25fc4c8";

        /// <summary>
        /// パッケージの名前です。
        /// </summary>
        public const string PackageName = "Case Converter";

        /// <summary>
        /// 全般設定のオプションを取得します。
        /// </summary>
        /// <returns>全般設定のオプション</returns>
        public GeneralOption GetGeneralOption()
        {
            return (GeneralOption)GetDialogPage(typeof(GeneralOptionPage)).AutomationObject;
        }

        protected override Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            ConvertCaseCommand.Initialize(this);
            return base.InitializeAsync(cancellationToken, progress);

        }

        ///// <summary>
        ///// パッケージを初期化します。
        ///// </summary>
        //protected override void Initialize()
        //{
        //    base.Initialize();
        //    ConvertCaseCommand.Initialize(this);
        //}
    }
}
