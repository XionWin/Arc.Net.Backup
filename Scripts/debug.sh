#!/bin/bash

WORK_SPACE_FOLDER="$1"
PROJECT_NAME="$2"
SSH_REMOTE="$3"


TARGET_USER="pi"
BIN_FOLDER="${WORK_SPACE_FOLDER}/App/bin/Debug/net8.0/"
TARGET_BIN_FOLDER="/home/${TARGET_USER}/documents/bin/${PROJECT_NAME}"

echo ${TARGET_BIN_FOLDER}

ssh "${ROOT_USER}@${SSH_REMOTE}" "killall -9 dotnet"
# Copy shader folder into resources folder
if ! rsync -avzr "${BIN_FOLDER}" "${TARGET_USER}@${SSH_REMOTE}:${TARGET_BIN_FOLDER}"; then
    # If rsync doesn't work, it may not be available on target. Fallback to trying SSH copy.
    if ! scp -r "${SHADER_FOLDER}" "${TARGET_USER}@${SSH_REMOTE}:${TARGET_BIN_FOLDER}"; then
        exit 2
    fi
fi
