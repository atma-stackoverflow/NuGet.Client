﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.ProjectModel {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.ProjectModel.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument cannot be null or empty..
        /// </summary>
        internal static string ArgumentNullOrEmpty {
            get {
                return ResourceManager.GetString("ArgumentNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid dependency target value &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidDependencyTarget {
            get {
                return ResourceManager.GetString("InvalidDependencyTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The pack options package type must be a string or array of strings in &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidPackageType {
            get {
                return ResourceManager.GetString("InvalidPackageType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error loading lock file &apos;{0}&apos; : {1}.
        /// </summary>
        internal static string Log_ErrorReadingLockFile {
            get {
                return ResourceManager.GetString("Log_ErrorReadingLockFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error reading &apos;{0}&apos; : {1}.
        /// </summary>
        internal static string Log_ErrorReadingProjectJson {
            get {
                return ResourceManager.GetString("Log_ErrorReadingProjectJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error reading &apos;{0}&apos; at line {1} column {2} : {3}.
        /// </summary>
        internal static string Log_ErrorReadingProjectJsonWithLocation {
            get {
                return ResourceManager.GetString("Log_ErrorReadingProjectJsonWithLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Imports contains an invalid framework: &apos;{0}&apos; in &apos;{1}&apos;..
        /// </summary>
        internal static string Log_InvalidImportFramework {
            get {
                return ResourceManager.GetString("Log_InvalidImportFramework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Problem reading the cache file {0} : {1}.
        /// </summary>
        internal static string Log_ProblemReadingCacheFile {
            get {
                return ResourceManager.GetString("Log_ProblemReadingCacheFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to resolve tool &apos;&apos;..
        /// </summary>
        internal static string MissingToolName {
            get {
                return ResourceManager.GetString("MissingToolName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package dependencies must specify a version range..
        /// </summary>
        internal static string MissingVersionOnDependency {
            get {
                return ResourceManager.GetString("MissingVersionOnDependency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tools must specify a version range..
        /// </summary>
        internal static string MissingVersionOnTool {
            get {
                return ResourceManager.GetString("MissingVersionOnTool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Central package management file doesn&apos;t contain version range for {0} package which is specified as CentralTransitive dependency in the lock file..
        /// </summary>
        internal static string PackagesLockFile_CentralPackageVersionRemoved {
            get {
                return ResourceManager.GetString("PackagesLockFile_CentralPackageVersionRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version specified in the packages.lock.json file is invalid. Current tooling supports version {0} and previous formats..
        /// </summary>
        internal static string PackagesLockFile_IncompatibleLockFileVersion {
            get {
                return ResourceManager.GetString("PackagesLockFile_IncompatibleLockFileVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project target frameworks are different than the lock file&apos;s target frameworks. Lock file target frameworks: {0}. Project target frameworks {1}..
        /// </summary>
        internal static string PackagesLockFile_MismatchedTargetFrameworks {
            get {
                return ResourceManager.GetString("PackagesLockFile_MismatchedTargetFrameworks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project target framework {0} was not found in the lock file..
        /// </summary>
        internal static string PackagesLockFile_NewTargetFramework {
            get {
                return ResourceManager.GetString("PackagesLockFile_NewTargetFramework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A new package reference was found {0} for the project target framework {1}..
        /// </summary>
        internal static string PackagesLockFile_PackageReferenceAdded {
            get {
                return ResourceManager.GetString("PackagesLockFile_PackageReferenceAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package references have changed for {0}. Lock file&apos;s package references: {1}, project&apos;s package references: {2}..
        /// </summary>
        internal static string PackagesLockFile_PackageReferencesHaveChanged {
            get {
                return ResourceManager.GetString("PackagesLockFile_PackageReferencesHaveChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package reference {0} version has changed from {1} to {2}..
        /// </summary>
        internal static string PackagesLockFile_PackageReferenceVersionChanged {
            get {
                return ResourceManager.GetString("PackagesLockFile_PackageReferenceVersionChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A new project reference was found {0} for {1}..
        /// </summary>
        internal static string PackagesLockFile_ProjectReferenceAdded {
            get {
                return ResourceManager.GetString("PackagesLockFile_ProjectReferenceAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project references {0} project dependencies has changed..
        /// </summary>
        internal static string PackagesLockFile_ProjectReferenceDependenciesHasChanged {
            get {
                return ResourceManager.GetString("PackagesLockFile_ProjectReferenceDependenciesHasChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project {0} has no compatible target framework. .
        /// </summary>
        internal static string PackagesLockFile_ProjectReferenceHasNoCompatibleTargetFramework {
            get {
                return ResourceManager.GetString("PackagesLockFile_ProjectReferenceHasNoCompatibleTargetFramework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project reference {0} has changed. Current dependencies count: {1}, lock file&apos;s dependencies count: {2}..
        /// </summary>
        internal static string PackagesLockFile_ProjectReferencesHasChange {
            get {
                return ResourceManager.GetString("PackagesLockFile_ProjectReferencesHasChange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transitive dependencies moved to be centraly managed invalidated the lock file..
        /// </summary>
        internal static string PackagesLockFile_ProjectTransitiveDependencyChanged {
            get {
                return ResourceManager.GetString("PackagesLockFile_ProjectTransitiveDependencyChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mistmatch between the requestedVersion of a lock file dependency marked as CentralTransitive and the the version specified in the central package management file. Lock file version {0}, central package management version {1}..
        /// </summary>
        internal static string PackagesLockFile_ProjectTransitiveDependencyVersionChanged {
            get {
                return ResourceManager.GetString("PackagesLockFile_ProjectTransitiveDependencyVersionChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project&apos;s runtime identifiers have changed from. Project&apos;s runtime identifiers: {0}, lock file&apos;s runtime identifiers {1}..
        /// </summary>
        internal static string PackagesLockFile_RuntimeIdentifiersChanged {
            get {
                return ResourceManager.GetString("PackagesLockFile_RuntimeIdentifiersChanged", resourceCulture);
            }
        }
    }
}
