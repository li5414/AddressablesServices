using Cysharp.Threading.Tasks;
using UnityEngine;

namespace AddressablesServices
{
    public interface IAddressablesLoaderSingle<in TKey, TAsset> : IAddressablesUnloader
        where TAsset : Object
    {
        UniTask PreloadAssetAsync(TKey key);

        UniTask<TAsset> LoadAssetAsync(TKey key);
        
        bool IsAssetLoaded(TKey key);

        TAsset GetAsset(TKey key);

        bool TryGetAsset(TKey key, out TAsset asset);

        void UnloadAsset(TKey key);
    }
}