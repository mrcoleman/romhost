/api
    /api/v1/
        GET /api/v1/systems -> returns a list of systems
        GET /api/v1/{system} -> returns a list of roms (paged) for that system
        GET /api/v1/{system}/{romId} -> returns basic metadata for the rom
        POST /api/v1/{system}/{romId} -> create new rom entry
        PUT /api/v1/{system}/{romId} -> update the rom entry
        DELETE /api/v1/{system}/{romId} -> deletes a rom and any files, metadata and patches
        GET /api/v1/{system}/{romId}/file -> returns the rom file/files
        GET /api/v1/{system}/{romId}/file/{region} -> returns a rom file for that region or falls back to the default rom if there is
            no region
        DELETE /api/v1/{system}/{romId}/file/{region} -> deletes the file for the region
        POST /api/v1/{system}/{romId}/file -> upload a file\
        POST /api/v1/{system}/{romId}/file/{region} -> uploads a rom file for a specific region
        GET /api/v1/{system}/{romId}/metadata/{metaId} -> returns the content of a metadata item
        POST /api/v1/{system}/{romId}/metadata/{metaId} -> posts a bit of metadata
        DELETE /api/v1/{system}/{romId}/metadata/{metaId} -> deletes a specific piece of metadata
        GET /api/v1/{system}/{romId}/patches -> get a list of patch
        GET /api/v1/{system}/{romId}/file/patch/{patchId} -> get the default rom file for a rom with a patch applied
        GET /api/v1/{system}/{romId}/file/{region}/patch/{patchId} -> get the rom file for a region with a patch applied
        POST /api/v1/{system}/{romId}/patch -> create a patch entity
        POST /api/v1/{system}/{romId}/patch/{patchId} -> save the patch file for a patch entity
        DELETE /api/v1/{system}/{romId}/patch/{patchId} -> deletes a patch
        GET /api/v1/search?q={query} -> do a full text search and returns a list of roms
        POST /api/v1/search -> do a search for specific fields and returns a list of roms
        POST /api/v1/job -> kicks off a background job with the posted parameters
        GET /api/v1/jobs -> get a list all current jobs and their status
        GET /api/v1/job/{jobId} -> gets that status of a job
        DELETE /api/v1/job/{jobId} -> cancel a job
        PUT /api/v1/job/{jobId} -> append parameters to a job

/web
